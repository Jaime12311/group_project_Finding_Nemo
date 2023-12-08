using System.Windows;

using RecipeWPF.ViewModels;
namespace RecipeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RecipeViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new RecipeViewModel();
            this.DataContext = viewModel;
        }
    }
}
