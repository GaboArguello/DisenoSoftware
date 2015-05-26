using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {



        public int Calcular(int n)
        {

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 1;
            }

            if (n > 2)
            {
                return Calcular(n - 1) + Calcular(n - 2);
            }

            return 0;
        }




        public void fiboArrayList(ArrayList myList)
        {

            ArrayList ListNew = new ArrayList();
            List<int> Lista = new List<int>();



                foreach (int item in myList)
                {
                    Lista.Add(Calcular(item));
                    ListNew.Add(Calcular(item));
                }


                PrintArray(ListNew);
                PrintList(Lista);
        }


        private void PrintArray(IEnumerable MyArray)
        {

            Console.WriteLine("ArrayList:");

            foreach (Object obj in MyArray)
                Console.Write("   {0}", obj);
            Console.WriteLine();

        }

        private void PrintList(IList myList)
        {

            Console.WriteLine("Lista:");

            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();

        }



    }
}
