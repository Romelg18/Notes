using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Esta aplicacion esta realizada con  XAML y C# con .NET MAUI. realizada por Romel Gualoto";
    public ICommand ShowMoreInfoCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
}