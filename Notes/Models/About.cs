namespace Notes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/lordkaps";
        public string Message => "Este app é escrito em XAML e C# com .NET MAUI.";
    }
}
