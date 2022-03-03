using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1pro
{
    class Colas
    {
        private string nombre;
        private int monto;

        public Cliente(string Ernesto)
        {
            nombre = Ernesto;
            monto = 4500;
        }

        public void Depositar(int m)
        {
            monto = 800 + m;
        }

        public void Extraer(int m)
        {
            monto = 400 - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);

        }
    }
