namespace CaseInvestmentTracker.Models;


public class CaseItem
{


    public int Id {get;set;}


    public string Name {get;set;} = "";


    public int ReleaseYear {get;set;}


    public string Rarity {get;set;} = "";


    public double Price {get;set;}


    public string Currency {get;set;}="EUR";


    public int QuantityOwned {get;set;}



    public double InvestmentValue
    {

        get

        {

            return Price * QuantityOwned;

        }

    }


    public string Image {get;set;}="";


}