using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Cliente : Usuario
    {
        private double LitrosCargados {  get; set; }
        public Cliente(string userName, double saldo, double litrosCargados) : base(userName, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
