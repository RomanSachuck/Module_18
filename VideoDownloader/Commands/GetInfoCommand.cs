namespace VideoDownloader
{
    internal class GetInfoCommand : Command
    {
        public GetInfoCommand(Receiver receiver, string videoUrl) : base(receiver, videoUrl) 
        { }
        public override async Task ExecudeAsync() => await _receiver.GetInfoAsync(_videoUrl);
    }
}
