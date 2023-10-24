using Practica6._2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6._2.Entities
{
    internal class Palabra
    {
        public string _Palabra {  get; set; }
        public Palabra(string Palabra) 
        {
            this._Palabra = Palabra;
        }
    }
}
//Práctica 6. Realiza una aplicación que lea una palabra e invierta el orden, por ejemplo, si recibes la
//palabra UTM el programa debe de invertirla y mostrar MTU.