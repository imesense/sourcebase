using System.Windows;
using System.Windows.Input;

using LibGit2Sharp;
using Ookii.Dialogs.Wpf;

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

    private void CreateRepository(object? commandParameter) {
        var openFolderDialog = new VistaFolderBrowserDialog();
        _ = openFolderDialog.ShowDialog();

        var path = openFolderDialog.SelectedPath;
        Repository.Init(path);
    }

    private RelayCommand? _createRepositoryCommand;
    public ICommand CreateRepositoryCommand => _createRepositoryCommand ??= new RelayCommand(CreateRepository);

    private void CloneRepository(object? commandParameter) {
        var openFolderDialog = new VistaFolderBrowserDialog();
        _ = openFolderDialog.ShowDialog();

        var source = "https://github.com/imesense/sourcebase-client.git";
        var path = openFolderDialog.SelectedPath;
        Repository.Clone(source, path);
    }

    private RelayCommand? _cloneRepositoryCommand;
    public ICommand CloneRepositoryCommand => _cloneRepositoryCommand ??= new RelayCommand(CloneRepository);
}
