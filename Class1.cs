using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {
        private DateTime DataOra { get; set; }
        private string Nome { get; set; }
        private string LocalitaAppuntamento { get; set; }

        public Appuntamento(DateTime dataOra, string nome, string localitaAppuntamento)
        {
            this.DataOra = dataOra;
            this.Nome = nome;
            this.LocalitaAppuntamento = localitaAppuntamento;
            
            if (DateTime.Now > dataOra)
            {
                throw new Exception("Attenzione: La data non può essere precedente a oggi!"); 
            }
          /*  if (typeof(DataOra) != typeof(DateTime))
            {
                throw new Exception("Attenzione: Non è nel formato corretto!");
            }*/
        }
        public void StampaTutto( List<Appuntamento>lista)
        {
            Console.WriteLine("Appuntamenti:");
            Console.WriteLine("Data  Orario  Nome  Località");
            Console.WriteLine( DataOra.ToString() +Nome + LocalitaAppuntamento);
        }
        public string Getnome()
        {
            return Nome;
        }

        public void Cambiadata(DateTime datanew)
        {
            this.DataOra= datanew;
        }

           
            }


        }



