using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoSmartphone.Models
{
    public abstract class SmartPhone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public void Ligar() 
        { 
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao() 
        { 
            Console.WriteLine("Recebendo Ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}