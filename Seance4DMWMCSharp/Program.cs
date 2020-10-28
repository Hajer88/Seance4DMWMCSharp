using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seance4DMWMCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car{PetName="aaa", Color ="Bleu",speed=100,Marque="BMW"},
                new Car{PetName="bbbb", Color ="noir",speed=100,Marque="AUDI"},
            };
            var c = from t in cars where t.speed > 60 select t;
            var cbm = from t in cars where t.speed > 60 && t.Marque=="BMWM" select t;
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            //Exercice 6 TD 4
            //Query Syntax
            string[] tabChaine = { "chaine 1","chaine 2"};
           IEnumerable<string> tab = from t in tabChaine where t.Contains("  ")
                                    select t;
            foreach(var s in tab)
            {
                Console.WriteLine(s);
            }
            //DotNotation Syntax
            IEnumerable<string> tab2 = tabChaine.Where(t => t.Contains(" ") && t.Contains("a"))
                .Select(t => t);

            Console.WriteLine("Hello World!");
            voiture v = new voiture();
            v[0] = "dddd";
            v[1] = "aaaa";
            v[2] = "cccc";
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
            //Déclarer une Liste de type générique (String)
            List<string> Voiture = new List<string>()
            { "1","2","3"};
            foreach (var item in Voiture)
            {
                Console.WriteLine(item);
            }
            //Exemple working with string
            //1. String
            string s1 = "bla bla bla";
            s1 = s1 + ".....";
            StringBuilder sb = new StringBuilder("bla bla bla");
            sb.Append("....");

        }
    }
    public class voiture : IEnumerable
    {
        
        
        string[] car = new string[3];
        //ICollection<string>
        //IList

        //Indexer -> méthode spécifique qui se comporte comme une collection
        //Possibilité de créer des Indexers à partir de classes, structures, etc..
        public string this[int Num]
        {
            get { return car[Num]; }
            set { car[Num] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var s in car)
        {
         yield return s;
        }
        }


        //Créer notre propre itérateur en utilisant Yield
        //public IEnumerator GetEnumerator()
        //{
        //    foreach (var s in car)
        //    {
        //        yield return s;
        //    }
        //}
    }
}
