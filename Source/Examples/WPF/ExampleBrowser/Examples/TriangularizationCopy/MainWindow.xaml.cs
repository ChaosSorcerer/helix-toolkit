using System.Windows;

namespace ExampleBrowser.Examples.TriangularizationCopy;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
[ExampleBrowser.Example("Shading issue", "Illustrated a regression in polygon shading (re-uses a part of the triangularization demo for this).")]
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
