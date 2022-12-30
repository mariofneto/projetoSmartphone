using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoSmartphone.Models
{
    public class Iphone : SmartPhone
    {
         public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"||| Instalando o aplicativo <<{nome}>> no {Modelo} |||");
        }
    }
}