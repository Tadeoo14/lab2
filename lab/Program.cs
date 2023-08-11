using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nro, tempString;
            string[] nombre = { "lucas","Ignacio","tadeo"};
            string [] apellido = {"abratti", "cordero","cardelli"};
            int [] legajo = {12345,02432,30616};
            string finalString = "";
            int alumnos  = 3; 
            DateTime[] fecha = { new DateTime(2023,12,30), new DateTime(2004,05,31), new DateTime(1999,04,23), };

            /*
            for(int i=0; i<alumnos; i++)
            {

                do
                {
                    Console.WriteLine("Ingrese el nro de legajo");
                    nro = Console.ReadLine();

                } while (!(int.TryParse(nro, out legajo[i]) && (legajo[i] > 0)));

                do
                {
                    Console.WriteLine("Ingrese la fecha");
                    tempString = Console.ReadLine();

                } while (!DateTime.TryParse(tempString, out fecha[i]));

                do
                {
                    Console.WriteLine("Ingrese un nombre");
                    nombre[i] = Console.ReadLine();

                }while (!(nombre[i].Length >= 4 && nombre[i].Length <= 15));

                do
                {
                    Console.WriteLine("Ingrese su apellido");
                    apellido[i] = Console.ReadLine();

                } while (!(apellido[i].Length >=4 && apellido[i].Length <= 15));
                
                finalString += $"{legajo[i].ToString().PadLeft(10)} |{nombre[i].PadLeft(10)} |{apellido[i].PadLeft(10)} |{fecha[i].ToString().PadLeft(15)}";
            }
            */

            for(int j =0; j < alumnos; j++)
            {
                finalString += $"{legajo[j].ToString().PadLeft(10)} |{nombre[j].PadLeft(10)} |{apellido[j].PadLeft(10)} |{fecha[j].ToShortDateString().PadLeft(15)}\n";
            }

            for (int x=0;x<alumnos;x++)
            {
                for (int y=x+1;y<alumnos;y++)
                {
                    if (legajo[x] > legajo[y])
                    {
                        //Ordeno el array de legajo
                        int aux = legajo[x];
                        legajo[x] = legajo[y];
                        legajo[y] = aux;

                        //Ordeno el array de nombres
                        string aux2 = nombre[x];
                        nombre[x] = nombre[y];
                        nombre[y] = aux2;

                        //Ordeno el array de apellidos
                        string aux3 = apellido[x];
                        apellido[x] = apellido[y];
                        apellido[y] = aux3;

                        //Ordeno el array de fechas
                        DateTime auxf = fecha[x];
                        fecha[x] = fecha[y];
                        fecha[y] = auxf;

                    }
                }
            }
            
            Console.WriteLine(finalString);

            Console.ReadKey();
            
        }
    }
}

/*
 int [] legs = new int [5] crea un array y le pasa un tamaño de cinco
 int [] legs = {10,20,30,40} 
 
 */
