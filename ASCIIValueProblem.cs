using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace ASCIIValueProblem

{

class ASCIIValueProblem

    {

staticvoid Main(string[] args)

        {

Console.WriteLine("\t\tName: Ehtesham Mehmood\n\t\tRoll No: 11014119-131\n\t\tSection: AE\n \t\t        UOG\n");

char a;

int b;

Console.WriteLine("Enter A Charater:");

            a = Convert.ToChar(Console.ReadLine());

            b = (int)a;

if (b >= 65 && b <= 90)

            {

 

Console.WriteLine("Entered Character Is Capital Letter:");

            }

if (b >= 97 && b <= 122)

            {

 

Console.WriteLine("Entered Character Is Small Letter:");

            }

if (b >= 48 && b <= 57)

            {

 

Console.WriteLine("Entered Character Is  Digit:");

            }

if (b == 0 && b <= 47 || b >= 58 && b <= 64 || b >= 91 && b <= 96 || b >= 123 && b <= 127)

            {

 

Console.WriteLine("Entered Character Is Special Symbols:");

            }

Console.ReadKey();

        }

    }

}