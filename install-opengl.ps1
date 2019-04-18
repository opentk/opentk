# Some modifications to this file copied from the VisPy project
# which is released under a BSD 3-clause license

# Original script: https://github.com/glue-viz/glue-vispy-viewers/blob/master/.install-opengl.ps1

#$MESA_GL_URL = "https://github.com/vispy/demo-data/raw/master/mesa/"
$MESA_GL_URL = "http://downloads.fdossena.com/Projects/Mesa3D/Builds/MesaForWindows-17.3.3.zip"
# Mesa DLLs found linked from:
#     http://qt-project.org/wiki/Cross-compiling-Mesa-for-Windows
# to:
#     http://sourceforge.net/projects/msys2/files/REPOS/MINGW/x86_64/mingw-w64-x86_64-mesa-10.2.4-1-any.pkg.tar.xz/download

function DownloadMesaOpenGL ($architecture) {
    $webclient = New-Object System.Net.WebClient
    $basedir = "$env:WINDIR/system32/"
    $filepath = $basedir + "opengl32.dll"
    # Download and retry up to 3 times in case of network transient errors.
    # $url = $MESA_GL_URL + "opengl32_mingw_" + $architecture + ".dll"
    $url = $MESA_GL_URL

    if (Test-Path $filepath) {
        Write-Host "OpenGL already installed"
        return
    }
    If(!(test-path "./temp"))
    {
          New-Item -ItemType Directory -Force -Path "./temp"
    }
    $temppath = "./temp/mesa.zip"
    Write-Host "Downloading" $url
    $retry_attempts = 2
    for($i=0; $i -lt $retry_attempts; $i++){
        try {
            $webclient.DownloadFile($url, $temppath)
            Expand-Archive -Force $temppath ./temp/
            Write-Host "Try saving at" $filepath
            cp ./temp/opengl32.dll $filepath
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


function main () {
    DownloadMesaOpenGL $env:PYTHON_ARCH
}

main