using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

try
{
    var cat = new Catalog();

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
                  "11. exit" +
                  "Optiune=";

    while (true)
    {
        Console.WriteLine(menu);  //Afiseaza meniul
        string option = Console.ReadLine();  //Citeste optiunea aleasa
        switch (option) //In functie de optiune se intampla o alta actiune
        {
            case "1":
                /// aici afisam toti studentii din catalog
                cat.GetStudents().ForEach(s => Console.WriteLine(s));
                break;
            case "2":
                /// aici citim id-ul de la tastatura si afisam studentul cu id-ul citit...
                /*
                 * csadkp
                 * dasdask
                 * 
                 * dasdas
                 */
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



class Catalog
{
    private List<string> studenti = new List<string>();
    public List<string> GetStudents() => new List<string>();
}
