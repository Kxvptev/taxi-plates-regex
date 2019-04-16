using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader taxiIn = File.OpenText(@"taxi.in");
            TextWriter taxiOut = File.CreateText(@"taxi.out");

            int platesNum = Convert.ToInt32(taxiIn.ReadLine());

            int taxiPlates = 0;

            string taxiTemplate = @"\A([1-7]{1}TAX|[1-7]{1}TBX|7{1}TEX) ([0-9]{3}[1-9]{1}|[1-9]{1}[0-9]{3}|[0-9]{1}[1-9]{1}[0-9]{2}|[0-9]{2}[1-9]{1}[0-9]{1})\Z";

            for (int i = 0; i < platesNum; i++)
            {
                string plate = taxiIn.ReadLine();

                if (Regex.IsMatch(plate, taxiTemplate))
                    taxiPlates++;
            }

            taxiOut.WriteLine(taxiPlates.ToString());

            taxiIn.Close();
            taxiOut.Close();
        }
    }
}
