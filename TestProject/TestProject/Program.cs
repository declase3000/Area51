using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // string hiddenWord="palabra";
           string hiddenWord = Console.ReadLine();

            string showWord="";

           Console.Clear();
          //  if (hiddenWord=="hola"){
           //     Console.WriteLine("Chau");

          //  } 

           // for (int i=0;i<3; i++){
             //   Console.WriteLine(hiddenWord);
             //   }

            for (int i=0; i<hiddenWord.Length;i++){

               // Console.WriteLine(hiddenWord);
               showWord +='*';
            }






            Console.WriteLine(hiddenWord);
            
           
                
            Console.Read();
        }
    }
}
