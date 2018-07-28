using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApplication1.DetaljiStudenta;
using static ConsoleApplication1.Student;

namespace ConsoleApplication1
{
    class Program
    {

        static public Student student = new Student();

        static void Main(string[] args)
        {

            Console.Write("Unesite ukupan broj studenata: ");

            string s = Console.ReadLine();
            if (IsNumeric(s))
            {
                Izracun(s);        
            }
            else
            {
                Console.Write("Unesite numeričku vrijednost: ");
                string s1 = Console.ReadLine();
                if (IsNumeric(s1)) { 
                Izracun(s1);
            }
            }

        }


        private static bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        static public void Izracun(string s) {
            int brojStudenata = -1;

            brojStudenata = Convert.ToInt32(s);
            for (int i = 1; i <= brojStudenata; i++)
            {
                Console.WriteLine("\nUnesite informacije za studenta " + i.ToString() + ":");

                unosZapisa();

            }

            PregledZapisa();
            // char ch = Console.ReadKey().KeyChar;
            System.Threading.Thread.Sleep(10000);




        }

        static public void PregledZapisa()
        {
            Console.WriteLine("____________________");



            Console.WriteLine("Ime                     ENG   MAT   FIZ   KEM    BIO     Prosjek");

            Console.WriteLine("__________");

            for (int i = 0; i < student.MaksimalanBroj; i++)

            {
                Console.Write("{0, -5}", i + 1);

                Console.Write("{0, -19}", student.listaStudenata[i].imeStudenta);

                Console.Write("{0, -7}", student.listaStudenata[i].ocjenaStudenta[0]);

                Console.Write("{0, -7}", student.listaStudenata[i].ocjenaStudenta[1]);

                Console.Write("{0, -7}", student.listaStudenata[i].ocjenaStudenta[2]);

                Console.Write("{0, -7}", student.listaStudenata[i].ocjenaStudenta[3]);

                Console.Write("{0, -7}", student.listaStudenata[i].ocjenaStudenta[4]);

                Console.Write("{0, -8}", student.listaStudenata[i].završnaOcjena);

                Console.WriteLine();

            }
            Console.WriteLine("________________");

        }




        static void unosZapisa()
        {
            Console.Write("Ime studenta:");
            string ime;
            int[] ocjene = new int[5];
            string[] predmeti = new string[5] { "ENG", "MAT", "FIZ", "KEM" ,"BIO" };
            ime = Console.ReadLine();
            int j = -1;

            for (int i = 1; i <= 5; i++)
            {
                j++;

                Console.Write("Predmet " + i.ToString() + ", " + predmeti[j] + " ocjena: ");
                ocjene[i - 1] = Convert.ToInt32(Console.ReadLine());
            

            }

            student.dodajZapis(ime, ocjene);

        }
    }





    


    }

