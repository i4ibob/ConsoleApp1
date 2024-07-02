using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Penal
    {
        public List<Pencil> pencils = new List<Pencil>();

        public Penal(List<Pencil> pencils)
        {
            this.pencils = pencils;
        }

        public void ShowPensils()
        {
            foreach (Pencil pencil in pencils)
            {
                pencil.ShowPencilInfo();
                Console.WriteLine();
            }
        }

        public void AddPencil(Pencil pencil)
        {
            pencils.Add(pencil);
        }

        public void RemovePencil(Pencil pencil)
        {
            pencils.Remove(pencil);
        }
    }
}