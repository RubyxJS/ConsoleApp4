using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            Country[] countries = new Country[3]{
            new Country("Ireland", "Dublin"),
            new Country("Nigeria", "Lagos"),
            new Country("England", "London")
            };
            foreach (Country country in countries)
            {
                Console.WriteLine(country.capital + " " + country.countryName);
            }
        }
        }
    class Country
    {
        public string countryName = "";
        public string capital = "";
        public Country(string countryName, string capital)
        {
            this.countryName = countryName;
            this.capital = capital;
        }
    }
}


