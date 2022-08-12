﻿using System.Windows;

using ImeSense.SourceBase.Client.Views;

namespace ImeSense.SourceBase.Client;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
        base.OnStartup(e);

        var mainWindow = new MainWindow();
        mainWindow.Show();
    }
}
