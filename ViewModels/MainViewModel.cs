using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CaseInvestmentTracker.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Case> Cases { get; set; }

        private decimal _totalInvested;
        public decimal TotalInvested
        {
            get => _totalInvested;
            set
            {
                _totalInvested = value;
                OnPropertyChanged();
            }
        }

        private decimal _currentValue;
        public decimal CurrentValue
        {
            get => _currentValue;
            set
            {
                _currentValue = value;
                OnPropertyChanged();
            }
        }

        private decimal _totalProfit;
        public decimal TotalProfit
        {
            get => _totalProfit;
            set
            {
                _totalProfit = value;
                OnPropertyChanged();
            }
        }

        private decimal _roi;
        public decimal ROI
        {
            get => _roi;
            set
            {
                _roi = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Cases = new ObservableCollection<Case>();

            // Beispiel-Daten
            Cases.Add(new Case
            {
                Name = "Operation Breakout Weapon Case",
                BuyPrice = 2.30m,
                CurrentPrice = 8.45m,
                Quantity = 50
            });

            Cases.Add(new Case
            {
                Name = "Gamma 2 Case",
                BuyPrice = 0.18m,
                CurrentPrice = 2.14m,
                Quantity = 200
            });

            Cases.Add(new Case
            {
                Name = "Prisma 2 Case",
                BuyPrice = 0.05m,
                CurrentPrice = 0.82m,
                Quantity = 1000
            });

            UpdatePortfolio();
        }

        public void UpdatePortfolio()
        {
            TotalInvested = Cases.Sum(c => c.Invested);
            CurrentValue = Cases.Sum(c => c.CurrentValue);
            TotalProfit = CurrentValue - TotalInvested;

            ROI = TotalInvested == 0
                ? 0
                : (TotalProfit / TotalInvested) * 100;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}