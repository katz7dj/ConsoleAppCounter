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
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________________________");

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

    }


    }

