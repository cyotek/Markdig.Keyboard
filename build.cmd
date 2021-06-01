@ECHO OFF

SETLOCAL

CALL ..\..\..\build\set35vars.bat

SET RELDIR=src\bin\Release\
SET PRJFILE=src\Markdig.Keyboard.csproj
SET DLLNAME=Markdig.Keyboard.dll

IF EXIST %RELDIR%*.nupkg DEL /F %RELDIR%*.nupkg
IF EXIST %RELDIR%*.snupkg DEL /F %RELDIR%*.snupkg
IF EXIST %RELDIR%*.zip DEL /F %RELDIR%*.zip

dotnet build %PRJFILE% --configuration Release

PUSHD %RELDIR%

REM CALL signcmd net35\%DLLNAME%
REM CALL signcmd net40\%DLLNAME%
REM CALL signcmd net452\%DLLNAME%
REM CALL signcmd net462\%DLLNAME%
REM CALL signcmd net472\%DLLNAME%

CALL signcmd net48\%DLLNAME%
CALL signcmd net472\%DLLNAME%
CALL signcmd net462\%DLLNAME%
CALL signcmd net46\%DLLNAME%
CALL signcmd netstandard2.0\%DLLNAME%
CALL signcmd netstandard2.1\%DLLNAME%
CALL signcmd netcoreapp2.1\%DLLNAME%
CALL signcmd netcoreapp3.1\%DLLNAME%
CALL signcmd net5.0\%DLLNAME%

%zipexe% a Cyotek.Markdig.Keyboard.x.x.x.zip -r

POPD

dotnet pack %PRJFILE% --configuration Release --no-build
CALL sign-package %RELDIR%*.nupkg
CALL sign-package %RELDIR%*.snupkg

ENDLOCAL
