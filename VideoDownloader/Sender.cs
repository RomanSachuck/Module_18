namespace VideoDownloader
{
    internal class Sender
    {
        private Command _comand;

        public void SetCommand(Command comand) => _comand = comand;
        public async Task Execute() => await _comand.ExecudeAsync();
    }
}
