@ECHO OFF
ECHO Starting PHP 8 FastCGI...
set PATH=C:\PHP;%PATH%
C:\Sociocon\core\php8\php-cgi.exe -b 127.0.0.1:9000