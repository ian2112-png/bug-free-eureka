using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Job
{
    
       private string _company;
       private string _jobTitle;
       private int _startYear;
       private int _endYear;

    public Job (string company, string jobTitle, int startYear, int endYear)

   {
    _company = company;
    _jobTitle = jobTitle;
    _startYear = startYear;
    _endYear = endYear;
   }
            public void DisplayNames ()
            {
            
            Console.WriteLine($"Job: {_jobTitle}, Company: {_company}, Start year: {_startYear}, End year: {_endYear} ");
            }

}
