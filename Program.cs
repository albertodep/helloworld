using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type  memorizzati nello stack
            int pippo = 3;
            var pippo2 = 2;
            //char carattere = 'j';
            //decimal valoreDecimale(); //valori monetari

            //Reference Type memorizzati nell'heap
            //string stringa;
            //string stringa2;
            //object oggetto;
           
            Person luca = new Person("Luca", "Lippi");
            Person Giovanni = new Person("Luca", "Lippi");
            //p.eta = 18;

            Console.WriteLine(luca.Anagrafica());
            Giovanni = luca;

            Giovanni.nome = "Giovanni";


            //stringa = 'la mia casa è bella';
            //stringa2 = stringa1;

            //Console.WriteLine(stringa);
            //Console.WriteLine(string2);




        }
    }
}
