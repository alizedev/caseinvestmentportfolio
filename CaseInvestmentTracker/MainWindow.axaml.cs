using Avalonia.Controls;
using CaseInvestmentTracker.Models;
using CaseInvestmentTracker.Services;
using System.Collections.ObjectModel;


namespace CaseInvestmentTracker;


public partial class MainWindow : Window
{

    public ObservableCollection<CaseItem> Cases {get;set;}


    public MainWindow()
    {
        InitializeComponent();


        Cases = new ObservableCollection<CaseItem>(
            CaseService.LoadCases()
        );


        DataContext = this;

    }

}