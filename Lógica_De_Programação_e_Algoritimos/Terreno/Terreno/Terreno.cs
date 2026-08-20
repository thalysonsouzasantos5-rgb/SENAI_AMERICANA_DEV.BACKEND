using System;
using System.Collections.Generic;
using System.Text;

namespace terreno
{
    internal static class Terreno
    {
        //Campos
        public static double largura;
        public static double comprimento;
        public static double valor;
        //1ºMétodos
        public static double CalcularArea()
        {
            return largura * comprimento;
        }
        //2ºMetodos
        public static double CalcularPreço()
        {
            return CalcularArea() * valor;
        }
    }
}