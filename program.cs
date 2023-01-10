using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-140", "Explorer" };
            String[] proton = { "Myvi", "Axia", "X50" };
            String[] toyota = { "Avanza", "Vios", "Alza" };

            String[,] parkingLot = { { "Mustang", "F-140", "Explorer" },
                                     { "Myvi", "Axia", "X50" },
                                     { "Avanza", "Vios", "Alza" }
                                };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Avanza 2023";

            /*    foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
                    
            }*/

            //yg atas for each keluar sebaris output
            //if nak mcm jadual kene wat nested loop

            for( int i = 0; i <parkingLot.GetLength(0); i++ )
            {
                for (int j = 0; j < parkingLot.GetLength(0); j++)
                {
                    Console.Write(parkingLot[i , j] + " ");
                }
                Console.WriteLine();
            }

                Console.ReadKey();  
        }
        
    }
    }





   
