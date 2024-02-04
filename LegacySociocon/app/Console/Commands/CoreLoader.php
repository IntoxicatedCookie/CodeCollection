<?php

////* COPYRIGHT NOTICE *\\\\
// 
// This file contains code from the Laravel package (https://laravel.com/), © 2011 - 2021 by Laravel LLC. 
// LizardLis Software is not affiliated or endorsed with Laravel LLC in any way. 
// © 2021 by LizardLis Software.

namespace App\Console\Commands;

use Illuminate\Console\Command;
use Illuminate\Support\Env;
use Symfony\Component\Console\Input\InputOption;
use Symfony\Component\Process\PhpExecutableFinder;
use Symfony\Component\Process\Process;
use Symfony\Component\Console\Formatter\OutputFormatterStyle;

class CoreLoader extends Command
{
    /**
     * The console command name.
     *
     * @var string
     */
    protected $name = 'coreloader';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Handles all servers at once';

    /**
     * Execute the console command.
     *
     * @return int
     *
     * @throws \Exception
     */
    public function handle()
    {
        chdir(public_path());

        $this->line('<fg=magenta>Initializing CoreLoader v0.3</>');
        $this->error('WARNING! This command will become obsolete soon and will be REMOVED. It\'s recommended to use the desktop application of CoreLoader instead.');
        $confirm = $this->confirm('Do you want to continue anyway?');

        if (!$confirm) {
            return $this->error('Cancelling the command...');
        }

        $environmentFile = $this->option('env') ? base_path('.env').'.'.$this->option('env') : base_path('.env');
        $hasEnvironment = file_exists($environmentFile);

        if ($hasEnvironment) {

            $environmentLastModified = $hasEnvironment ? filemtime($environmentFile) : now()->addDays(30)->getTimestamp();
                $this->line('<fg=white;bg=green>Starting the processes...</>');
                $db = Env::get('DB_EXE');
                $mail = Env::get('MAIL_EXE');
                $gateway = Env::get('GATEWAY_EXE');
                $web = Env::get('WEB_EXE'); 
                $nginx_stop = Env::get('NGINX_STOP');

                $this->line('<comment>*** DATABASE SERVER ***</comment>');
                $db_process = new Process([$db]);
                $db_process->start();
                $this->info('Started');

                $this->line('<comment>*** MAILSERVER ***</comment>');
                $mail_process = new Process([$mail]);
                $mail_process->start();
                $this->info('Started');

                $this->line('<comment>*** GATEWAY ***</comment>');
                $gate8_process = new Process(['C:\Sociocon\core\nginx\fastcgi\gate_8.bat']);
                $gate8_process->start();

                $gate7_process = new Process(['C:\Sociocon\core\nginx\fastcgi\gate_7.bat']);
                $gate7_process->start();
                $this->info('Started');

                $this->line('<comment>*** WEBSERVER ***</comment>');
                $web_process = new Process([$web]);
                $web_process->start();
                $this->info('Started');

                while ($web_process->isRunning()) {
                    while (true) {
                        usleep(500 * 1000);
                    }
                }

                $this->error('Exiting the command...');
                $nginx_process = new Process([$nginx_stop]);
                return $nginx_process->start();
        } else {
            return $this->error('Environment file does not exist or was not detected.');
        }
    }

    /**
     * Get the key for the command.
     *
     * @return string
     */
    protected function cl_key()
    {
        if (Env::get('CL_KEY')) {
            $key = Env::get('CL_KEY');

            return $key;
        } else {
            throw new \Exception('Environment variable for CL_KEY is not set');
        }
    }

    /**
     * If the issued key is invalid.
     *
     * @return string
     */
    protected function invalid_cl_key()
    {
        $this->error('Key is invalid, not initiating the process.');
        $confirm = $this->confirm('Retry?', false);
        if ($confirm === true) {
            return $this->handle();
        } else {
            $this->error('Cancelling the command...');
        }
    }

    /**
     * Get the console command options.
     *
     * @return array
     */
    protected function getOptions()
    {
        return [
            ['host', null, InputOption::VALUE_OPTIONAL, 'The host address to serve the application on', '127.0.0.1'],
            ['port', null, InputOption::VALUE_OPTIONAL, 'The port to serve the application on', Env::get('SERVER_PORT')],
            ['tries', null, InputOption::VALUE_OPTIONAL, 'The max number of ports to attempt to serve from', 10],
            ['no-reload', null, InputOption::VALUE_NONE, 'Do not reload the development server on .env file changes'],
        ];
    }
}
