using System.Windows;

using LibGit2Sharp;
using Ookii.Dialogs.Wpf;

using ImeSense.SourceBase.Client.Views;
using ImeSense.Helpers.Mvvm.ComponentModel;
using ImeSense.Helpers.Mvvm.Input;

namespace ImeSense.SourceBase.Client.ViewModels;

public class MainViewModel : ObservableObject {
    private static void ExitApplication() {
        Application.Current.Shutdown();
    }

    private IRelayCommand? _exitMenuItemCommand;
    public IRelayCommand ExitMenuItemCommand => _exitMenuItemCommand ??= new RelayCommand(ExitApplication);

    private void ShowSettingsWindow() {
        var settingsWindow = new SettingsWindow();
        settingsWindow.Show();
    }

    private IRelayCommand? _showSettingsWindowCommand;
    public IRelayCommand ShowSettingsWindowCommand => _showSettingsWindowCommand ??= new RelayCommand(ShowSettingsWindow);

    private void ShowAboutWindow() {
        var aboutWindow = new AboutWindow();
        aboutWindow.Show();
    }

    private IRelayCommand? _showAboutWindowCommand;
    public IRelayCommand ShowAboutWindowCommand => _showAboutWindowCommand ??= new RelayCommand(ShowAboutWindow);

    private void CreateRepository() {
        var openFolderDialog = new VistaFolderBrowserDialog();
        _ = openFolderDialog.ShowDialog();

        var path = openFolderDialog.SelectedPath;
        _ = Repository.Init(path);
    }

    private IRelayCommand? _createRepositoryCommand;
    public IRelayCommand CreateRepositoryCommand => _createRepositoryCommand ??= new RelayCommand(CreateRepository);

    private void CloneRepository() {
        var openFolderDialog = new VistaFolderBrowserDialog();
        _ = openFolderDialog.ShowDialog();

        var source = "https://github.com/imesense/sourcebase-client.git";
        var path = openFolderDialog.SelectedPath;
        _ = Repository.Clone(source, path);
    }

    private IRelayCommand? _cloneRepositoryCommand;
    public IRelayCommand CloneRepositoryCommand => _cloneRepositoryCommand ??= new RelayCommand(CloneRepository);
}
