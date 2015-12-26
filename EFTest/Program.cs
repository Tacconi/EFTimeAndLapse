using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeAndLapseContext sc = new TimeAndLapseContext();

            Console.WriteLine("numero TimingTypes: {0}", sc.TimingTypes.Count());
            Console.WriteLine("numero Timings: {0}", sc.Timings.Count());
            Console.WriteLine("numero Teams: {0}", sc.Teams.Count());
            Console.WriteLine("numero Players: {0}", sc.Players.Count());

            Console.WriteLine("fatto");
            Console.Read();








            //Class nuovaClasse = new Class();
            //nuovaClasse.Name = "5Inf";

            //sc.Classes.Add(nuovaClasse);

            //Student nuovoStudente = new Student();
            //nuovoStudente.LastName = "Tacconi";
            //nuovoStudente.BirthDate = DateTime.Now;
            //nuovoStudente.Class = nuovaClasse;
            //sc.Students.Add(nuovoStudente);


            //sc.SaveChanges();

        }
    }
}
