namespace VideoDownloader
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new Sender();
            var receiver = new Receiver();
            int choice;
            string videoUrl;
            string outputFilePath;

            while (true)
            {
                Console.WriteLine($"{Environment.NewLine}Что будем делать?{Environment.NewLine}" +
                    $"1 - Скачать видео.{Environment.NewLine}" +
                    $"2 - Получить информацию о видео.{Environment.NewLine}{Environment.NewLine}" +
                    $"Ответьте цифрой 1 или 2:{Environment.NewLine}");

                choice = Input.GetCorrectChoice();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{Environment.NewLine}Введите ссылку на видео:");
                        videoUrl = Input.GetCorrectUrl();

                        Console.WriteLine($"{Environment.NewLine}Введите путь для сохранения видео на вашем компьютере:");
                        outputFilePath = Input.GetCorrectPath();

                        sender.SetCommand(new DownloadCommand(receiver, videoUrl, outputFilePath));

                        break;
                    case 2:
                        Console.WriteLine($"{Environment.NewLine}Введите ссылку на видео:");
                        videoUrl = Input.GetCorrectUrl();

                        sender.SetCommand(new GetInfoCommand(receiver, videoUrl));

                        break;
                }

                await sender.Execute();

                Console.WriteLine($"{Environment.NewLine}Если хотите поработать еще - нажмите 1 {Environment.NewLine}" +
                    $"Если хотите выйти - нажмите 2");

                if (Input.GetCorrectChoice() == 2)
                    break;
            }
        }
    }
}
