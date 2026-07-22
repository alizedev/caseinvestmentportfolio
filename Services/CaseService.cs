using System.Text.Json;
using CaseInvestmentTracker.Models;


namespace CaseInvestmentTracker.Services;


public class CaseService
{


    public List<CaseItem> LoadCases()
    {

        string path =
            "Data/cases.json";


        if(!File.Exists(path))
            return new List<CaseItem>();


        string json =
            File.ReadAllText(path);



        return JsonSerializer.Deserialize<List<CaseItem>>(json)
               ?? new List<CaseItem>();


    }



}