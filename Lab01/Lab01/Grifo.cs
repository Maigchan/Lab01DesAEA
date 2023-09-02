using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Grifo
    {
        public List<Usuario> usuarios { get; set; }


        public Grifo(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }

        private int Count = 0;
        public void ShowUsers(List<Usuario> usuarios)
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"{Count++}");
                usuario.ShowInfo();
            }
        }
    }
}
