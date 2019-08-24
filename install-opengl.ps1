# Some modifications to this file copied from the VisPy project
# which is released under a BSD 3-clause license

# Original script: https://github.com/glue-viz/glue-vispy-viewers/blob/master/.install-opengl.ps1

#$MESA_GL_URL = "https://github.com/vispy/demo-data/raw/master/mesa/"
$MESA_GL_URL = "https://github.com/jvbsl/MesaBinary/releases/download/19/opengl_win_dll.zip"
# Mesa DLLs found linked from:
#     http://qt-project.org/wiki/Cross-compiling-Mesa-for-Windows
# to:
#     http://sourceforge.net/projects/msys2/files/REPOS/MINGW/x86_64/mingw-w64-x86_64-mesa-10.2.4-1-any.pkg.tar.xz/download

function grantRights($file) {
        takeown /f $file
        icacls $file /grant "${env:ComputerName}\${env:UserName}:F"
}
function revokeRights($file) {
        icacls "$file" /C /reset
        icacls "$file" /inheritance:d
        icacls "$file" /setowner "NT SERVICE\TrustedInstaller"
}
function DownloadMesaOpenGL() {
    $webclient = New-Object System.Net.WebClient
    $filepath = $basedir + "opengl32.dll"
    # Download and retry up to 3 times in case of network transient errors.
    # $url = $MESA_GL_URL + "opengl32_mingw_" + $architecture + ".dll"
    $url = $MESA_GL_URL
    If (test-path "./temp")
    {
        Remove-Item -Recurse -Force -Path "./temp"
    }
    New-Item -ItemType Directory -Force -Path "./temp"
    $temppath = "./temp/mesa.zip"
    Write-Host "Downloading" $url
    $retry_attempts = 2
    for($i=0; $i -lt $retry_attempts; $i++){
        try {
            $webclient.DownloadFile($url, $temppath)
            Expand-Archive -Force $temppath ./temp/
            break
        }
        Catch [Exception]{
            Start-Sleep 1
        }
    }
    if (Test-Path $filepath) {
        Write-Host "File saved at" $filepath
    } else {
        # Retry once to get the error message if any at the last try
        $webclient.DownloadFile($url, $temppath)
    }
}
function InstallMesaOpenGL ($arch,$basedir)
{
    $source_path = "./temp/build/$arch/opengl32.dll"
    if (Test-Path $source_path)
    {
        $filepath = $basedir + "opengl32.dll"
        if (Test-Path $filepath)
        {
            Write-Host "change old opengl32.dll rights"
            grantRights $filepath
            Write-Host "Move old opengl32.dll(->opengl32.dll_old) in favour of mesa opengl"
            Rename-Item -Path $filepath -NewName opengl32.dll_old
        }
        Write-Host "Try saving at" $filepath
        cp $source_path $filepath
    }
    else
    {
        Write-Host "OpenGL32 not found: $source_path"
    }
}
function InstallAllMesaOpenGL()
{
    if ([IntPtr]::Size -eq 8)
    {
        InstallMesaOpenGL "x86" "$env:WINDIR\SysWOW64\"
        InstallMesaOpenGL "x86_64" "$env:WINDIR\system32\"
    }
    elseif([IntPtr]::Size -eq 4)
    {
        InstallMesaOpenGL "x86" "$env:WINDIR\system32\"
    }
    else
    {
        Write-Host "Invalid host architecture"
    }
}

function RemoveMesaOpenGL($basedir)
{
    $filepath = $basedir + "opengl32.dll"
    $filepath_old = $basedir + "opengl32.dll_old"
    if (Test-Path $filepath_old)
    {
        Write-Host "Restore old opengl32.dll"
        Remove-Item $filepath -Force
        Rename-Item -Path $filepath_old -NewName opengl32.dll
        revokeRights $filePath
    }
}

function RemoveAllMesaOpenGL()
{
    RemoveMesaOpenGL "$env:WINDIR\system32\"
    RemoveMesaOpenGL "$env:WINDIR\SysWOW64\"
}


if (($Args.Count -gt 0) -and ($args[0] = "uninstall"))
{
    RemoveAllMesaOpenGL
}
else
{
    DownloadMesaOpenGL
    InstallAllMesaOpenGL 
}
