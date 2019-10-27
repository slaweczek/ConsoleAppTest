using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
         static void Main(string[] args)
         {
            uint countDictionary = GetValueFromKeyboard();
            if (countDictionary > 0) 
            {
                var listDictionary = new List<string[]>();
                CreateDictionary(countDictionary, ref listDictionary);

                var value = Vocabulary.SpreadLists(listDictionary.ToArray());
                DisplayValuesFromDictionary(value);
            }

            Console.ReadKey();
         }

         private static uint GetValueFromKeyboard()
         {
            string result = string.Empty;
            Console.WriteLine("Podaj ilość słowników");
            result = Console.ReadLine();

            uint countDictionary;
            bool val = uint.TryParse(result, out countDictionary);

            if (!val)
            {
                Console.WriteLine("Nie można przekonwertować podanego znaku proszę wprowadzić liczbę!");
            }

                return countDictionary;
         }

         private static void DisplayValuesFromDictionary(string[][] value) 
         {
            Console.WriteLine("Wynik:");

            foreach (var item in value[0])
            {
                Console.WriteLine(item);
            }
         }

         private static void CreateDictionary(uint countDictionary, ref List<string[]> listDictionary) 
         {
            string result = string.Empty;

            for (int i = 0; i < countDictionary; i++)
            {
                Console.WriteLine(string.Format("Wprowadź wartości słownika {0} w formacie: A,B,C oraz naciśnij ENTER", i));
                result = Console.ReadLine();

                string[] words = result.Split(',');
                listDictionary.Add(words);
            }
         }
    }
}