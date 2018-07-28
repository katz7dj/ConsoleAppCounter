using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public List<DetaljiStudenta> listaStudenata = new List<DetaljiStudenta>();

        public int MaksimalanBroj;


        public int dodajZapis(string ime, int[] ocjena)
        {

            DetaljiStudenta stud = new DetaljiStudenta();

            stud.imeStudenta = ime;
            stud.ocjenaStudenta = ocjena;
            stud.završnaOcjena = 0;

            for (int i = 0; i < 5; i++)
          //  {

                stud.završnaOcjena += stud.ocjenaStudenta[i];
                listaStudenata.Add(stud);
                MaksimalanBroj = listaStudenata.Count;
            stud.završnaOcjena = stud.završnaOcjena / 5;


            //}


            return 1;
        }

    }
}
