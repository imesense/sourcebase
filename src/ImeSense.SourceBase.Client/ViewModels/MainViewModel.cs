using System.Windows;

using ImeSense.SourceBase.Client.Views;

namespace ImeSense.SourceBase.Client.ViewModels;

public class MainViewModel : BaseViewModel {
    private RelayCommand? _exitMenuItemCommand;
    public RelayCommand ExitMenuItemCommand => _exitMenuItemCommand ??= new RelayCommand(_ => {
        Application.Current.Shutdown();
    });

    private RelayCommand? _showSettingsWindowCommand;
    public RelayCommand ShowSettingsWindowCommand => _showSettingsWindowCommand ??= new RelayCommand(_ => {
        var settingsWindow = new SettingsWindow();
        settingsWindow.Show();
    });
}
