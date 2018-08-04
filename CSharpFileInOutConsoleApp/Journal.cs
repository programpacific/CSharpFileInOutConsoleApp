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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to your journal.\n\n\"There is nothing so useless as doing efficiently that which should not be done at all.\" - Peter Drucker");            

            writeMore:
            Console.Write("\n\nWhat would you like to remember?: ");
            string TestLog = Console.ReadLine().ToLower(); ;

            using (StreamWriter file = new StreamWriter(@"C:\Users\New\Desktop\TestLog.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(TestLog + "\n");
            }

            string StoredValue = File.ReadAllText(@"C:\Users\New\Desktop\TestLog.txt");

            // You could at this point convert it into an "int", but not much reason to do it at this point of the application, unless it's built upon at a later point.
            // The way it is designed now allows for a little bit more usability and was good practice!

            //int IntValue = Int32.Parse(StoredInt); // You'd change then below code to write this value instead.

            // But here it is anyways! Although if you were to handle more than one number as the program is currently designed you'd have to implement some special handling 
            //of the text files writing format. With only one integer it works perfectly, only when two values have been entered will it cause an error.

            Console.WriteLine("\n\nStored Values:\n{0}", StoredValue);
            Console.Write("Would you like to write more to the log? ");
            string UserResponse = Console.ReadLine();

            if  (UserResponse == "yes" || UserResponse == "yeah" || UserResponse == "y" || UserResponse == "ya")
            {
                goto writeMore;
            }

            Console.WriteLine("\nIn hopes of reaching the moon, men fail to see the flower that blossom at their feet. \"Albert Schweitzer\"\n\nPress enter to exit!");
            Console.ReadLine();

            
        }
    }
}
