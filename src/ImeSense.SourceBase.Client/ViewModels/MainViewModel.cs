using System.Windows;

namespace ImeSense.SourceBase.Client.ViewModels;

public class MainViewModel : BaseViewModel {
    private RelayCommand? _exitMenuItemCommand;
    public RelayCommand ExitMenuItemCommand => _exitMenuItemCommand ??= new RelayCommand(_ => {
        Application.Current.Shutdown();
    });
}
