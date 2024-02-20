namespace VideoDownloader
{
    internal class DownloadCommand : Command
    {
        private string _outputFilePath;
        public DownloadCommand(Receiver receiver, string videoUrl, string outputFilePath) : base(receiver, videoUrl) => _outputFilePath = outputFilePath;
        public override async Task ExecudeAsync() => await _receiver.DownloadAsync(_videoUrl, _outputFilePath);
    }
}
