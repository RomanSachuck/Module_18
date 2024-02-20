namespace VideoDownloader
{
    internal static class Input
    {
        public static int GetCorrectChoice()
        {
            int input = 0;

            while (!int.TryParse(Console.ReadLine(), out input) || input != 1 && input != 2)
                Console.WriteLine("Неверный ввод! Повторите попытку.");

            return input;
        }

        public static string GetCorrectUrl()
        {
            string sampleStartUrl = "https://www.youtube.com/";
            string result;

            result = Console.ReadLine();
  
            while(result.Length < sampleStartUrl.Length || result == string.Empty || result.Substring(0, sampleStartUrl.Length) != sampleStartUrl)
            {
                Console.WriteLine("Неверный ввод! Повторите попытку.");

                if (result.Length < sampleStartUrl.Length || result.Substring(0, sampleStartUrl.Length) != sampleStartUrl)
                    Console.WriteLine($"Начало ссылки должно быть {sampleStartUrl}");

                result = Console.ReadLine();
            }

            

            return result;
        }

        public static string GetCorrectPath()
        {
            string result;

            result = Console.ReadLine();

            while (result == null || result == string.Empty || result.Substring(result.Length - 4) != ".mp4")
            {
                Console.WriteLine($"{Environment.NewLine}Неверный ввод! Повторите попытку.");

                if (result.Substring(result.Length - 4) != ".mp4")
                    Console.WriteLine("Последним элементом пути должно быть название видео с расширением .mp4");
                    
                result = Console.ReadLine();    
            }

            return result;
        }
    }
}
