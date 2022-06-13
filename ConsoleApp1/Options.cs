using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Options
    {



         public static void options()
        {

            char First_Name;
            char Last_Name;
            int Salary;


            char ej1;

            Console.WriteLine("--payroll--");
            Console.WriteLine("-----------------");
            Console.WriteLine("if you want to see yor discoun in health choose this (1) ");


            ej1 = char.Parse(Console.ReadLine());
            switch (ej1)
            {

                case '1': Health(); break;


            }


        }

        static void Health()
        {

            float Salary;
            float Health;

            Console.WriteLine("please digit your salary: ");

            Salary = Convert.ToSingle(Console.ReadLine());

            Health = (float)(Salary * 1.0125);
            Console.WriteLine("this is yuor discount in health: " + Health);


        }
    }
}


    













     




