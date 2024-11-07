using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Amy_Puertos
{
    public enum Propiedades
    {
        [Description("Expresion Regular")]
        Puerto1 = 8980,
        [Description("Calculadora")]
        Puerto2 = 8981,
        [Description("Agenda")]
        Puerto3 = 8982,

        Puerto4 = 8983,
        Puerto5 = 8984,
        Puerto6 = 8985,
        Puerto7 = 8986,
        Puerto8 = 8987,
        Puerto9 = 8988,
        Puerto10 = 8989,
        Puerto11 = 8990
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int Puerto = 0;
            Console.WriteLine("Ingresa un puerto");
            Puerto = Convert.ToInt32(Console.ReadLine());
            switch ((Propiedades)Puerto)
            {
                case Propiedades.Puerto1:
                    Console.WriteLine("Configurando puerto 8980, Expresion Regular");
                    break;
                case Propiedades.Puerto2:
                    Console.WriteLine("Configurando puerto 8981, Calculadora");
                    break;
                case Propiedades.Puerto3:
                    Console.WriteLine("Configurando puerto 8982, Agenda");
                    break;
                case Propiedades.Puerto4:
                    Console.WriteLine("Configurando puerto 8983, ----");
                    break;
                case Propiedades.Puerto5:
                    Console.WriteLine("Configurando puerto 8984, ----");
                    break;
                case Propiedades.Puerto6:
                    Console.WriteLine("Configurando puerto 8985, ----");
                    break;
                case Propiedades.Puerto7:
                    Console.WriteLine("Configurando puerto 8986, ----");
                    break;
                case Propiedades.Puerto8:
                    Console.WriteLine("Configurando puerto 8987, ----");
                    break;
                case Propiedades.Puerto9:
                    Console.WriteLine("Configurando puerto 8988, ----");
                    break;
                case Propiedades.Puerto10:
                    Console.WriteLine("Configurando puerto 8989, ----");
                    break;
                case Propiedades.Puerto11:
                    Console.WriteLine("Configurando puerto 8990, ----");
                    break;
                default:
                    Console.WriteLine("Puerto no válido");
                    break;
            }
            Console.ReadKey();
        }
        
    }
}

