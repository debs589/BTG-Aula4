﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG_aula4
{
    internal class Calculadora
    {
        public decimal valor1;
        public decimal valor2;

        public decimal Somar()
        {
            return valor1 + valor2;
        }
        public decimal Subtrair()
        {
            return valor1 - valor2;
        }
        public decimal Multiplicar()
        {
            return valor1 * valor2;
        }
        public decimal Dividir()
        {
            return valor1 / valor2;
        }

        public void ImprimirResultado(decimal resultado)
        {
            Console.WriteLine($"\nO resultado é: {resultado}");
        }
    }
}
