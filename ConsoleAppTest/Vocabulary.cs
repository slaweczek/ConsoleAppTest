using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Vocabulary
    {
        public static string[][] SpreadLists(params string[][] lists) 
        {
            var listTemp = new List<string[]>();

            IEnumerable<string> list = new List<string> { null };
            foreach (var item in lists)
            {
                list = list.SelectMany(s => item.Select(k => s + k));
            }

            listTemp.Add(list.ToArray());

            return listTemp.ToArray();
        }
    }
}
