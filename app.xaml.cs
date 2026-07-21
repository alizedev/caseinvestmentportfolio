using System.Windows;

namespace CaseInvestmentTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Hauptfenster erstellen
            MainWindow mainWindow = new MainWindow();

            // Fenster anzeigen
            mainWindow.Show();
        }
    }
}