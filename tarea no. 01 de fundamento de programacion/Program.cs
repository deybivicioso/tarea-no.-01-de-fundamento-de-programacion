using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_no._01_de_fundamento_de_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio_no_01();

            ejercicio_no_02();

            ejercicio_no_03();

            ejercicio_no_04();

            ejercicio_no_05();

            ejercicio_no_06();

            ejercicio_no_07();
        }
        static void ejercicio_no_01()
        {
           
            int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 01\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            variable_X = variable_a + (variable_b / variable_c) / (variable_a / variable_b) + variable_c;

            Console.WriteLine("el resultado es " + variable_X + ("\n"));
        }
        static void ejercicio_no_02()
        {
          
            int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 02\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            variable_X = ((variable_a + variable_b) + (variable_b / variable_c)) / variable_c;

            Console.WriteLine($"el valor de la operacion es{variable_X}" + ("\n"));
        }
        static void ejercicio_no_03()
        {
           int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_x = 0;

            Console.WriteLine("ejercicio no 03\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            variable_x = variable_a / (variable_a + variable_b) / variable_a / (variable_a - variable_b);

            Console.WriteLine($"el valor de la operacion es{variable_x}"+("\n"));
        }
        static void ejercicio_no_04()
        {
           
            int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 04\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            variable_X = variable_a + (variable_b / variable_a) + variable_b + (variable_b / variable_c) / variable_a + (variable_b / variable_c) + variable_a;

            Console.WriteLine($"el valor de la operacion es{variable_X}" + ("\n"));
        }
        static void ejercicio_no_05()
        {
           
            int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 05\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            variable_X = variable_a + variable_b + variable_c / (variable_a + (variable_b / variable_c));

            Console.WriteLine($"el valor de la operacion es{variable_X}" + ("\n"));
        }
        static void ejercicio_no_06()
        {
            
            int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_d = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 06\n");

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_d = int.Parse(Console.ReadLine());

            variable_X = variable_a + variable_b + (variable_c / (variable_d * variable_a)) / variable_a + variable_b * (variable_c / variable_d);

            Console.WriteLine("el resultado de la operacion es " + variable_X + ("\n"));
        }
        static void ejercicio_no_07()
        {
           int variable_a = 0;
            int variable_b = 0;
            int variable_c = 0;
            int variable_d = 0;
            int variable_X = 0;

            Console.WriteLine("ejercicio no 07\n");
            
            Console.WriteLine("ingrese el numero de su preferencia");

            variable_a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_c = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero de su preferencia");

            variable_d = int.Parse(Console.ReadLine());

            variable_X = (variable_a + (variable_b / variable_c) + variable_d) / variable_a;

            Console.WriteLine($"el resultado de la operacion es{variable_X}" + ("\n"));
        }
    }
}
   


