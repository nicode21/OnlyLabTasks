using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ILanguageService
    {
        public delegate T MyDelegate1<in T1, out T>(T1 variable);
        public delegate TResult MyDelegate2<in T1, in T2, out TResult>(T1 variable, T2 variable2);

        public void GetUsefulLanguages(MyDelegate2<int, string, string> func1, MyDelegate1<DateTime, bool> func2, MyDelegate1<int, int> func3, Dictionary<Languages, int> dictionary);

    }
}
