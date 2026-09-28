using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace MisClip_Editor.UI.Views;

public partial class MainWindow : Window
{
    private bool _test = false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void NavButton_Click(object? sender, RoutedEventArgs e)
    {
        if (_test)
        {
            TestContent.ColumnDefinitions[1].Width = new GridLength(0);
        }
        else
        {
            TestContent.ColumnDefinitions[1].Width = GridLength.Auto;
        }
        Test.IsVisible = !Test.IsVisible;
        Splitter.IsVisible = !Splitter.IsVisible;
    }
}