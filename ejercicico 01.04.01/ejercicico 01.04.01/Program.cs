using System;

namespace ejercicico_01._04._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada---------------------------------------------
            Console.WriteLine("ingrese bGrados: ");
            double bGrados = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            //Proceso
            
            double t = Math.Sqrt((((y) * (y)) + ((z) * (z))));
            
            double c = Math.Asin((z/t));
            double cGrados = c * (180.0 / Math.PI);
            double a = 180 - 90 - cGrados;
            double m = a + bGrados;
            double dGrados = 180 - 90 - m;
            double d = dGrados * (Math.PI / 180.0);
            double w = (z / (Math.Sin(d)));
            double i = Math.Sqrt(((w) * (w)) - ((z) * (z)));
            
            //salida
            double x = i - y;
            Console.WriteLine("x: " + x);
            



            //Entradas2---------------------------------------------------
            Console.WriteLine("ingrese dGrados1: ");
            double dGrados1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese bGrados1: ");
            double bGrados1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese y1: ");
            double y1 = double.Parse(Console.ReadLine());

            //proceso2

            double eGrados1 = 180 - dGrados1 - bGrados1;
            double cGrados1 = 180 - eGrados1;
            double a1 = 180 - 90 - cGrados1;
            double c1 = cGrados1 * (Math.PI / 180.0);
           // double t1 = ((y1 / (Math.Cos(c1))));
            
            //salida2
            double z1 = (((Math.Tan (c1))* y1));
            Console.WriteLine("z1: " + z1);


            //Entrada3----------------------------------------------------------
            Console.WriteLine("ingrese w2: ");
            double w2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese dGrados2: ");
            double dGrados2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese x2: ");
            double x2 = double.Parse(Console.ReadLine());

            //proceso2
            double d2 = dGrados2 * (Math.PI / 180.0);
            double m2 = (((Math.Cos(d2)))*w2);
           
            //salida2
            double y2 = m2 - x2;
            Console.WriteLine("y2: " + y2);




            //Entrada 3------------------------------------------------------

            Console.WriteLine("ingrese w3: ");
            double w3 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese t3: ");
            double t3 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cGrados3: ");
            double cGrados3 = double.Parse(Console.ReadLine());

            //proceso 3
            double c3 = cGrados3 * (Math.PI / 180.0);
            double z3 = ((Math.Sin(c3)) * t3);
            double y3 = Math.Sqrt(((t3) * (t3)) - ((z3) * (z3)));
            double m3 = Math.Sqrt(((w3) * (w3)) - ((z3) * (z3)));

            //salida3
            double x3 = m3 - y3;
            Console.WriteLine("x3: " + x3);
        }
    }
}
