using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string name;
        public string surname;
        public string eta;
        public string sesso;
        public int altezza;
        public double peso;

        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.cognome = surname;
            this.sesso = "sconosciuto";

        }
        public Person(string nome)
        {
        }
     
        public string Anagrafica()
        {
        string anagrafica = this.name + this.cognome;
        return anagrafica;

        }
        public double BMI()
        {
         

        }


    }
}
