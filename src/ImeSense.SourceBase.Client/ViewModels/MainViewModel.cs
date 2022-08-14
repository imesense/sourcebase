using System.Windows;

using ImeSense.SourceBase.Client.Views;

namespace ImeSense.SourceBase.Client.ViewModels;

public class MainViewModel : BaseViewModel {
    private void ExitApplication(object? commandParameter) {
        Application.Current.Shutdown();
    }

    private RelayCommand? _exitMenuItemCommand;
    public RelayCommand ExitMenuItemCommand => _exitMenuItemCommand ??= new RelayCommand(ExitApplication);

    private void ShowSettingsWindow(object? commandParameter) {
        var settingsWindow = new SettingsWindow();
        settingsWindow.Show();
    }

    private RelayCommand? _showSettingsWindowCommand;
    public RelayCommand ShowSettingsWindowCommand => _showSettingsWindowCommand ??= new RelayCommand(ShowSettingsWindow);

    private void ShowAboutWindow(object? commandParameter) {
        var aboutWindow = new AboutWindow();
        aboutWindow.Show();
    }

    private RelayCommand? _showAboutWindowCommand;
    public RelayCommand ShowAboutWindowCommand => _showAboutWindowCommand ??= new RelayCommand(ShowAboutWindow);
}
