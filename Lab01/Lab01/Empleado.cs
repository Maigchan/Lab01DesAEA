using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Empleado : Usuario
    {
        private double Sueldo { get; set; }
        public Empleado(string userName, double saldo, double sueldo) : base(userName, saldo)
        {
            Sueldo = sueldo;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }

    }

}
