using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptExceptionTest
{
    class Program
    {
        public static Double[] vals = new Double[10];
        public static int index = 0;
        public static String promptText = "";

        static void Main(string[] args)
        {
            FillArray();
            promptInfo(); 
            

           





        }

        public static void FillArray()
        {


            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = i;
            }


        }

        public static void promptInfo()
        {
           
            try
            {
                
                promptUser(); 
            }

            catch (IndexOutOfRangeException)
            {
                

                while ((index >= vals.Length || index < 0))
                {

                    promptText = "Index out of bounds.";
                   
                    Console.Write(promptText);
                    index = Convert.ToInt32(Console.ReadLine());

                    Console.ReadLine();
                   
                    

                }
                promptInfo();



            }



        }

        public static void promptUser()
        {
            while (index >= 0 && index <= vals.Length)
            {

                promptText = "Enter index: ";
                Console.Write(promptText);
                index = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Subscript : " + index + " \n Value in array: " + vals[index]);
                Console.Write("\n");
                Console.Write("\n");

            }
        }

       

       
    }

    
    }

