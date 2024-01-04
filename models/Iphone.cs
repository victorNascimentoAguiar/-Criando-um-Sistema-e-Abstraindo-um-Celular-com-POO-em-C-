using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abistraindo_um_POO_de_um_celular.models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        } 
        // TODO: Sobrescrever o método "InstalarAplicativo"
         public override void InstalarAplicativo(string NomeApp )
       {
            Console.WriteLine($"Instalando o aplicativo {NomeApp} no Iphone");
       }
    }
}