using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeriesParallel
{
    class SeriesParallell
    {
        
        static void Main(string[] args)
        {
            double i, n;
            double sum = 0;
            Console.WriteLine("------------Series Or Parallel------------");
            Console.WriteLine("Type Full Name Of element ex : Resistor");
            Console.WriteLine("Enter element name Resistor(in ohms)/ Inductor(in henry)/ Capacitor(in farad)");
            string elementName = Console.ReadLine();
            Console.WriteLine("Type whether Series/ Parallel");
            string elementConst = Console.ReadLine();
            if (elementName == "Resistor"||elementName == "resistor")
            {
                Console.WriteLine("Enter Number Of Resistors");
                n = Convert.ToDouble(Console.ReadLine());
                
                if (elementConst == "Series" || elementConst == "series")
                {
                    
                    for(i = 1; i <= n; i++)
                        
                    {
                        Console.WriteLine("R" + i);                 
                        double temp = Convert.ToDouble(Console.ReadLine());
                        sum = sum + temp;

                    }
                    Console.WriteLine("Req ohms " + sum);
                    Console.ReadLine();

                }
                else if(elementConst == "Parallel" || elementConst == "parallel")
                {
                    for (i = 1; i <= n; i++)

                    {

                        Console.WriteLine("R" + i);
                        double temp = Convert.ToDouble(Console.ReadLine());
                        double temp1 = (1 / temp);
                        sum = sum + temp1;

                    }
                    Console.WriteLine("Req ohms " + sum);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                }

            }
            if (elementName == "Inductor" || elementName == "inductor")
            {
                Console.WriteLine("Enter Number Of Resistors");
                n = Convert.ToDouble(Console.ReadLine());


                if (elementConst == "Series" || elementConst == "series")
                {

                    for (i = 1; i <= n; i++)

                    {

                        Console.WriteLine("L" + i);
                        double temp = Convert.ToDouble(Console.ReadLine());
                        sum = sum + temp;

                    }
                    Console.WriteLine("Leq ohms " + sum);
                    Console.ReadLine();

                }
                else if (elementConst == "Parallel" || elementConst == "parallel")
                {
                    for (i = 1; i <= n; i++)

                    {

                        Console.WriteLine("L" + i);
                        double temp = Convert.ToDouble(Console.ReadLine());
                        double temp1 = (1 / temp);
                        sum = sum + temp1;

                    }
                    Console.WriteLine("Leq ohms " + sum);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                }

            }
            if (elementName == "Capacitor" || elementName == "capacitor")
            {
                Console.WriteLine("Enter Number Of Resistors");
                n = Convert.ToDouble(Console.ReadLine());


                if (elementConst == "Parallel" || elementConst == "parallel")
                {

                    for (i = 1; i <= n; i++)

                    {

                        Console.WriteLine("C" + i);
                        double temp = Convert.ToDouble(Console.ReadLine());
                        sum = sum + temp;

                    }
                    Console.WriteLine("Ceq ohms " + sum);
                    Console.ReadLine();

                }
                else if (elementConst == "Series" || elementConst == "series")
                {
                    for (i = 1; i <= n; i++)

                    {

                        Console.WriteLine("C" + i);
                        double temp = Convert.ToDouble(Console.ReadLine());
                        double temp1 = (1 / temp);
                        sum = sum + temp1;

                    }
                    Console.WriteLine("Ceq ohms " + sum);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
