using System.Windows;
using CaseInvestmentTracker.ViewModels;

namespace CaseInvestmentTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ViewModel mit der UI verbinden
            DataContext = new MainViewModel();
        }
    }
}