using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program.Class1;

namespace ConsoleApplication1
{
    class Program
    {

        static public Student student = new Student();

        static public void PregledZapisa()
        {
            Console.WriteLine("____________________");



            Console.WriteLine("SNo Student Name        ENG   MAT   FIZ   KEM    BIO     Total");

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

                Console.Write("{0, -7}", student.listaStudenata[i].završnaOcjena);

                Console.WriteLine();

            }
            Console.WriteLine("________________");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Student MarkList Application");

            Console.Write("Unesite ukupan broj studenata: ");

            int brojStudenata = -1;
            string s = Console.ReadLine();

            brojStudenata = Convert.ToInt32(s);

            for (int i = 1; i <= brojStudenata; i++)
            {
                Console.WriteLine("\nEnter " + i.ToString() + " Student Information\n");

                unosZapisa();

            }

            PregledZapisa();
            char ch = Console.ReadKey().KeyChar;
        }


        static void unosZapisa()
        {
            Console.Write("Ime studenta:");
            string ime;
            int[] ocjene = new int[5];

            ime = Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Predmet 1" + i.ToString() + "ocjena: ");
                ocjene[i-1] = Convert.ToInt32(Console.ReadLine());


            }

            student.dodajZapis(ime, ocjene);

        }
    }



    class DetaljiStudenta {
        public string imeStudenta;
        public int[] ocjenaStudenta = new int[5];
        public int završnaOcjena;    

    }

    class Student {
        public List<DetaljiStudenta> listaStudenata = new List<DetaljiStudenta>();

        public int MaksimalanBroj;


        public int dodajZapis(string ime, int[] ocjena) {

            DetaljiStudenta stud = new DetaljiStudenta();

            stud.imeStudenta = ime;
            stud.ocjenaStudenta = ocjena;
            stud.završnaOcjena = 0;

            for (int i = 0; i < 5; i++)
            {

                stud.završnaOcjena += stud.ocjenaStudenta[i];
                listaStudenata.Add(stud);
                MaksimalanBroj = listaStudenata.Count;


            }


            return 1;
        }

    }


    }

