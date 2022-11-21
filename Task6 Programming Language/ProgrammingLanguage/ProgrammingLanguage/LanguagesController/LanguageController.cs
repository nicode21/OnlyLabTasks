using Domain;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Service.Services.LanguageService;

namespace ProgrammingLanguage.LanguagesController
{
    public class LanguageController 
    {
        public static void UsefulLanguage()
        {
            ILanguageService languageService = new LanguageService();

            languageService.GetUsefulLanguages(CheckPower,CheckCreatingDate,UpdatePopularity,GetAllLanguages());
        }

        private static string CheckPower(int power,string name)
        {
            if (power>100)
            {
                return $" ---> Gucu Yeterlidir.";
            }
            else
            {
                return null;
            }
        }


        private static bool CheckCreatingDate(DateTime date)
        {
            return date>DateTime.Now.AddDays(-500);
        }

        private static int UpdatePopularity(int popularity)
        {
            return popularity*2;
        }

        public static Dictionary<Languages, int> GetAllLanguages()
        {
            Dictionary<Languages, int> dictionary = new Dictionary<Languages, int>();

            Languages lang1 = new Languages("C#", DateTime.Now.AddDays(-400), 300, 100000);
            Languages lang2 = new Languages("JavaScript", DateTime.Now.AddDays(-200), 400, 100000);
            Languages lang3 = new Languages("Dart", DateTime.Now.AddDays(-1000), 100, 100000);
            Languages lang4 = new Languages("Phyton", DateTime.Now.AddDays(-650), 100, 100000);
            Languages lang5 = new Languages("C++", DateTime.Now.AddDays(-100), 2500, 100000);

            dictionary.Add(lang1, 0);
            dictionary.Add(lang2, 1);
            dictionary.Add(lang3, 2);
            dictionary.Add(lang4, 3);
            dictionary.Add(lang5, 4);

            return dictionary;

        }
    }
}
