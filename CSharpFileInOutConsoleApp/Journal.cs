using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFileInOutConsoleApp

   //    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
  //1. Ask a user for a number.
 //2. Log that number to a text file.
//3. Print the text file back to the user.

{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkGray;                                       Just in case you wanted to change it up in the future!
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to your journal.\n\n\"There is nothing so useless as doing efficiently that which should not be done at all.\" - Peter Drucker");            

            writeMore:
            Console.Write("\n\nWhat would you like to remember?: ");
            string TestLog = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\New\Desktop\TestLog.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(TestLog + "\n");
            }

            string StoredValue = File.ReadAllText(@"C:\Users\New\Desktop\TestLog.txt");


            Console.WriteLine("\n\nStored Values:\n{0}", StoredValue);
            Console.Write("Would you like to write more to the log? ");
            string UserResponse = Console.ReadLine();

            if  (UserResponse == "yes" || UserResponse == "yeah" || UserResponse == "y" || UserResponse == "ya")
            {
                goto writeMore;
            }

            Console.WriteLine("\n\"In hopes of reaching the moon, men fail to see the flower that blossom at their feet.\" - Albert Schweitzer\n\nHAVE A GREAT DAY!");
            Console.ReadLine();

            
        }
    }
}
