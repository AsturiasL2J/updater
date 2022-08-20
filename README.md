Updater
=====================
A sample game updater/launcher made for test servers. This code can be used as a starting point for building your custom better verion of the updater.

PS: Not all exceptions/issues have been gracefully handled. Hence be careful while using it on your live server!

Features
---------
* 7zip (LZMA) compression used to keep patch files smaller in size.
* Has full check as well as patch check functionality.
* Target dot net version is 2.0 so that players need not install latest dot net frameworks in order to run the updater.
* Includes a patch generator to quickly build a patch for your game.
* Updater is very simple lightweight 297KB executable without unnecessary functionalities.

Basic Usage
------------
* Open the solution in Visual Studio 2017 or above.
* Update the ``PatchHost`` as well as ``WebHost`` variables in Updater project to your domain or IP address
* Build both updater as well as patcher projects with x86 target platform.
* Open ``Updater.exe`` and generate patch twice. First time with all game files in the input directory and once done rename generated ``patch.ini`` to ``full.ini``. Second time with only important files you want to check each time updater starts.
* Upload all the generated files into the patch directory of your web server. In order to updater to work as intended ``
http://yourwebserver/patch/full.ini
`` as well ``
http://yourwebserver/patch/patch.ini
`` should exist.

Known Issues
-------------
* As mentioned before not all errors have been handled properly and hence updater might crash if unhandled exception occurs.
* Sometime file download progress bar gets stuck while downloading files.
* Full check takes hours to finish if client folder has no previous game files as multipart file download and multi-thread file processing has not been implemented yet.

Report errors with screenshots in the issues section of this project.

--------------[PTBR]---------
* Compressão 7zip (LZMA) usada para manter os arquivos de patch menores em tamanho.
* Tem verificação completa, bem como funcionalidade de verificação de patch.
* A versão dotnet de destino é 2.0 para que os jogadores não precisem instalar as estruturas dotnet mais recentes para executar o atualizador.
* Inclui um gerador de patches para criar rapidamente um patch para o seu jogo.
* Updater é um executável leve de 1mb muito simples, sem funcionalidades desnecessárias.

Uso básico
------------
* Abra a solução no Visual Studio 2017 ou superior.
* Atualize as variáveis ``PatchHost``, bem como ``WebHost`` no projeto Updater para seu domínio ou endereço IP
* Compile sempre com a build para processadores x86.
* Abra ``Lineage2Shield Patch Generator.exe`` e gere o patch. Depois do patch pronto, o arquivo ``patch.ini`` copie e cole e renomeie para ``temp.ini``. Segunda vez com apenas arquivos importantes que você deseja verificar cada vez que o atualizador é iniciado.
* Carregue todos os arquivos gerados no diretório de patches do seu servidor web. Para que o atualizador funcione como pretendido, ``http://yourwebserver/patch/full.ini`` também deve existir ``http://yourwebserver/patch/patch.ini``.

Problemas conhecidos
-------------
* Como mencionado antes, nem todos os erros foram tratados adequadamente e, portanto, o atualizador pode travar se ocorrer uma exceção não tratada.
* Às vezes, a barra de progresso do download de arquivos fica travada durante o download de arquivos.
* A verificação completa leva horas para ser concluída se a pasta do cliente não tiver arquivos anteriores do jogo, pois o download de arquivos multipart e o processamento de arquivos multithread ainda não foram implementados.

Relate erros com capturas de tela na seção de problemas deste projeto.
