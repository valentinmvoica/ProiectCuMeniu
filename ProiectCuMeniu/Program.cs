using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    internal class Program
    {

        // Main Method
        public static void Main(String[] args)
        {
            try
            {
              

                string menu = "Alegeti optiunea:\n" +
                              "1.Afiseaza toti studentii\n" +
                              "2.Afiseaza un student dupa ID\n" +
                              "3.Adauga un student\n" +
                              "4.Sterge student\n" +
                              "5.Modifica date student\n" +
                              "6.Modificare adresa student\n" +
                              "7.Acorda nota unui student\n" +
                              "8.Afiseaza media generala a unui student\n" +
                              "9.Afisati media generala a unui student in functie de materie\n" +
                              "10.Afisati studentii in ordinea descrescatoare a mediilor\n" +
                              "11. exit"+
                              "Optiune=";

                while (true)
                {
                    Console.WriteLine(menu);  //Afiseaza meniul
                    string option = Console.ReadLine();  //Citeste optiunea aleasa
                    switch (option) //In functie de optiune se intampla o alta actiune
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        case "9":
                            break;
                        case "10":
                            break;
                        case "11":
                            return;
                        default:
                            Console.WriteLine("\nOptiunea aleasa nu este valida\n");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}