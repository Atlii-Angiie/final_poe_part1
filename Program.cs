using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_poe_part1
{//start of namespace
    public class Program
    {//start of class
        private static readonly string username;

        static void Main(string[] args)
        {//start of main method

            //create an instance of the class 
            //class with constructor 
            new welcome_voice() { };

            //instance for the logo class with constructor
            new chat_logo() { };

            //instance for the user response class with constructor
             new user_response() { };

            //creating an instance for a class user_interface
            user_interface user_interfaces = new user_interface();

            //call the method welcoming user
            user_interfaces.welcoming();

            //call the method to ask for the name
            string username = user_interfaces.ask_name();

            // giving user a example on what he can ask about 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("hey " + username + " Ask us anything related to cybersecurity and I will be happy to help :");
            Console.WriteLine(" - Passwords");
            Console.WriteLine(" - Phishing");
            Console.WriteLine(" - Safe browsing");
            Console.WriteLine(" - Viruses");
            Console.WriteLine(" - Online safety tips");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor(); 

            //call the method to chat with the user
            user_response user_Response = new user_response();
            user_Response.ai_chat(username);

        }//end of main method
    }//end of class
}//end of namespace