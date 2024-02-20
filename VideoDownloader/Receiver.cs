using YoutubeExplode;
using YoutubeExplode.Converter;

namespace VideoDownloader
{
    internal class Receiver
    {
        private YoutubeClient _client;

        public Receiver()
        {
            _client = new YoutubeClient();
        }

        public async Task DownloadAsync(string videoUrl, string outputFilePath)
        {

            try
            {
                await _client.Videos.DownloadAsync(videoUrl, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
                Console.WriteLine($"{Environment.NewLine}Готово!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{Environment.NewLine}Произошла ошибка!{Environment.NewLine}{ex.Message}");
            }
        }

        public async Task GetInfoAsync(string videoUrl)
        {
            try
            {
                var info = await _client.Videos.GetAsync(videoUrl);

                Console.WriteLine(info.Author);
                Console.WriteLine(info.Title);
                Console.WriteLine(info.Description);
                Console.WriteLine($"{Environment.NewLine}Готово!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{Environment.NewLine}Произошла ошибка!{Environment.NewLine}{ex.Message}");
            }
            
        }
    }
}
