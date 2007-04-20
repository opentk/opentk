cd..
dir /s /b /ad | find ".svn" > del.txt
for /F "delims='" %%f in (del.txt) do rmdir /q /s "%%f"
del del.txt
cd Build