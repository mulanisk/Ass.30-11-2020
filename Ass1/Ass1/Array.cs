using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    class Array
    { 
        static void Main(string[] args)    //Main method
        {
            string[] mylist = { "Sahil", "Ameya", "Amruta", "Yug", "Suyog", "John", "Mukesh" };   //array initialization

            //Search string 
            foreach (string i in mylist)
            {
                if (i.Contains("Sahil"))
                {

                    Console.WriteLine("Searched string available in array is : " + i);
                    Console.WriteLine(" ");
                }

                
            }

            //Search string containing  character "a"
            foreach (string m in mylist)

            {
                if (m.Contains("a") || m.Contains("A"))
                {
                    Console.WriteLine(m);

                }
                Console.WriteLine(" ");


            }


            //Show the elements in array which have odd length
            var n = mylist.Length;
            
            for (int i = 0; i < n; i++)
            {
                String x = mylist[i].ToString();



                if (x.Length % 2 != 0)
                {
                    Console.WriteLine(mylist[i]);
                }
            }


            Console.ReadLine();

            

        }
    }
}
