using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add ("jeden");
            myAL.Add("dwa");
            myAL.Add("trzy");
            myAL.Add("zayzyz");    // obiekty tablicy moga byc rozne typy int string char itd
            myAL.Add("cztery");
            myAL.Add(2);
            myAL.Add('A');
            myAL.Add('a');
            myAL.Add(2);
            myAL.Add("ostatni");
            //myAL.Sort(); // działa jeżeli w tablicy są obiekty tego samego typu np int lub string lub chary.. sortuale np alfabetycznie lub inty od min do max
            Console.WriteLine("ilosc elemernow {0}",myAL.Count);
            Console.WriteLine();
            Console.WriteLine("Pojemnosc tablicy {0}", myAL.Capacity); 
            Console.WriteLine();
            Console.WriteLine("Pierwszy: {0} ", myAL[0]);
            Console.WriteLine();
            Console.WriteLine("Ostatni: {0} ", myAL[myAL.Count-1]);
            Console.WriteLine();
            Console.WriteLine("czy w myAL jest wartosc 2?");
            Console.WriteLine();
            for(int i = 0; i<myAL.Count-1; i++) //sprawdza czy jest jakis konkretny obiekt
            {
                if (myAL[i] == "jeden")
                {
                    Console.WriteLine("Tak");
                    break;
                }
                else Console.WriteLine("Nie");
            }
            Console.WriteLine();
            Console.WriteLine("Objekty w liscie");

            foreach (Object obj in myAL)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine();
            myAL.Remove("jeden");
            Console.WriteLine("Objekty w liscie po usunięciu wybranego obiektu o nazwie jeden"); //usuwa pierwsze wystapienie obiektu

            foreach (Object obj in myAL)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine();
            myAL.RemoveAt(2);
            Console.WriteLine("Objekty w liscie po usunięciu wybranego indeksu w tym przypadku usunelismy obiekt o indeksie 2 arraylist");  //usuwa obiekt o okreslonym indexie w tablicy

            foreach (Object obj in myAL)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.ReadKey();
              


        }
    }
}
