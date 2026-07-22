using System.Collections.ObjectModel;
using CaseInvestmentTracker.Models;
using CaseInvestmentTracker.Services;


namespace CaseInvestmentTracker.ViewModels;


public class MainViewModel
{


    public ObservableCollection<CaseItem> Cases {get;set;}



    public MainViewModel()
    {


        var service =
            new CaseService();



        Cases =
            new ObservableCollection<CaseItem>(
                service.LoadCases()
            );


    }



}