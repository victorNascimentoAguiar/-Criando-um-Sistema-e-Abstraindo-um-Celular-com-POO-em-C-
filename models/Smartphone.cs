using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abistraindo_um_POO_de_um_celular.models
{
        public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo {get; set;}
        private string Imei { get; set; }
        public int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}