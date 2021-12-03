@echo off
taskkill /im Ordisoftware.Hebrew.Words.exe
ping localhost -n 3 >NUL
start "" ..\Bin\Ordisoftware.Hebrew.Words.exe --reset