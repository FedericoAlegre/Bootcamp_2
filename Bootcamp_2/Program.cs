using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace Bootcamp_2
{
    class Program
    {        
        static void llenarArreglo(int[] a)
        {
            for(int i =0; i<a.Length; i++)
            {
                bool f = false;
                do
                {
                    Console.Write("Ingrese un numero: ");
                    string s = Console.ReadLine();
                    try
                    {
                        a[i]= int.Parse(s);
                        f=true;
                        
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Ingreso un dato invalido!!");
                    }
                } while (f!=true);
            }
        }

        

        
        static void pairprogramming2()
        {
            int[] arr = new int[5];
            llenarArreglo(arr);
            Array.Sort(arr);
            Queue cola = new Queue();
            for(int i=0; i<arr.Length; i++)
            {
                cola.Enqueue(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(cola.Dequeue());
            }


        }

        static void ejercicio1()
        {

        }
        static void Main(string[] args)
        {                
            Console.WriteLine("Bootcamp challenge 2");
            bool f = false;
            int option=0;
            do
            {
                Console.WriteLine("0- Apagar\n1- ejercicio 1\n2- Pair Pogramming 2\n");
                string s = Console.ReadLine();
                try
                {
                    option = int.Parse(s);
                    f = true;

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingreso un dato invalido!!");
                }
            } while (f != true);

            while (option!=0)
            {
                switch(option)
                {
                    case 1:
                        {
                            ejercicio1();
                            break;
                        }
                    case 2:
                        {
                            pairprogramming2();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("NUMERO INVALIDO");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.WriteLine("0- Apagar\n1- ejercicio 1\n2- Pair Pogramming 2\n");
                    string s = Console.ReadLine();
                    try
                    {
                        option = int.Parse(s);
                        f = true;

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Ingreso un dato invalido!!");
                    }
                } while (f != true);

            }
        }        
    }
}
