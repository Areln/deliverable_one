//Aaron Anderson

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace deliverableone
{
    class Program
    {
        static double[] inputs = new double[3];
        static double inputTotal;
        private static double inputAverage;
        private static double inputMax;
        private static double inputMin;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 dollar amounts.");
            for (int i = 0; i < 3; i++)
            {
                inputs[i] = Convert.ToDouble(Console.ReadLine());
                if (i == 0)
                {
                    inputMin = inputs[i];
                }

                Console.WriteLine("Input " + (i+1) + ": " + string.Format("{0:C2}", inputs[i]));
                inputTotal += + inputs[i];
                if (inputs[i] > inputMax)
                {
                    inputMax = inputs[i];
                }

                if (inputs[i] < inputMin)
                {
                    inputMin = inputs[i];
                }
            }

            inputAverage = (double) (inputTotal / 3);

            Console.WriteLine();
            Console.WriteLine("Lowest: " + string.Format("{0:C2}", inputMin));
            Console.WriteLine("Highest: " + string.Format("{0:C2}", inputMax));
            Console.WriteLine("Average: " + string.Format("{0:C2}", inputAverage));
            Console.WriteLine("Total: " + string.Format("{0:C2}", inputTotal));
            Console.WriteLine("Swedish: " + string.Format(new CultureInfo("sv-SE"),"{0:C}", inputTotal));
            Console.WriteLine("Japanese: " + string.Format(new CultureInfo("ja"), "{0:C}",(inputTotal * 107.92)));
            Console.WriteLine("Thai: " + string.Format(new CultureInfo("th-TH"), "{0:C}", (inputTotal * 30.58)));

            Console.ReadLine();
        }
    }
}
