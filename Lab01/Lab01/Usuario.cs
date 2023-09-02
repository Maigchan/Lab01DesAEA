using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Usuario
    {
        public string UserName { get; set; }

        public double Saldo { get; set; }


        public Usuario(string userName, double saldo)
        {
            UserName = userName;
            Saldo = saldo;

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Nombre: {UserName}\nSaldo: {Saldo}\n");
        }
    }


}
