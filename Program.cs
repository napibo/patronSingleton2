using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronSingleton
{
    internal class Program
    {
        //this class is for methods that we can use in all classes
        class MG
        {
            private static MG instance;

            private MG()
            {
            }
            //with this method we "create" and instance as a new 
            public static MG GetInstance()
            {
                if (instance == null) { 
                    instance = new MG();
                }
                return instance;
            }
            //methods for the project
            public void GetConexion(string conexion = "") {
                //logic to get conexion string 
            }

            public void writeLine(string text)
            {
                Console.WriteLine(text);
            }

            


        }
        static void Main(string[] args)
        {
            MG mg1 = MG.GetInstance();
            Console.WriteLine("Instane 1 MG: " + mg1 );
            MG mg2 = MG.GetInstance();
            Console.WriteLine("Instane 2 MG: " + mg2 );
            Console.WriteLine("");
            mg1.writeLine("olaola");


            Console.ReadKey();
        }
    }
}
