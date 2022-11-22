using Domain;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LanguageService : ILanguageService
    {
        public void GetUsefulLanguages(ILanguageService.MyDelegate2<int, string, string> func1, ILanguageService.MyDelegate1<DateTime, bool> func2, ILanguageService.MyDelegate1<int, int> func3, Dictionary<Languages, int> dictionary)
        {
            foreach (KeyValuePair<Languages, int> item in dictionary)
            {
                Console.WriteLine(item.Key + "\n\n");

                if (func2(item.Key.CreatingDay) == true)
                {
                    Console.WriteLine(func1(item.Key.Power, item.Key.Name));
                    Console.WriteLine($"Gucunun 2 qati : {func3(item.Key.Popularity)}");
                    Console.WriteLine($"ID is : {item.Key.Id} --> Programming Language is : {item.Key.Name}\n\n");
                }
            }
        }
    }
}
