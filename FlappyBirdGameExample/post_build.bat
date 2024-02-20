@ECHO OFF
set res_dir= %2Resources\*
set out_dir= %3%4

ECHO .
ECHO ========== Starting Post Build Event ==========
ECHO .

ECHO post_build.bat called for project: %1
ECHO copying resources from %res_dir% to %out_dir%tackresources
rmdir /Q /S %out_dir%tackresources
ECHO deleted tackresources folder at %out_dir%
mkdir %out_dir%tackresources
ECHO created tackresources folder at %out_dir%
xcopy /e %res_dir% %out_dir%\tackresources
ECHO copying additional files from %adfiles_dir% to %out_dir%
xcopy /y /e %adfiles_dir% %out_dir%

ECHO .
ECHO ========= Completed Post Build Event ==========
ECHO .