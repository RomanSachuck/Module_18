namespace VideoDownloader
{
    internal abstract class Command
    {
        protected Receiver _receiver;
        protected string _videoUrl;

        public Command(Receiver receiver, string videoUrl)
        {
            _receiver = receiver;
            _videoUrl = videoUrl;
        }

        public abstract Task ExecudeAsync();
    }
}
