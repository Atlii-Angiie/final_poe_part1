using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_poe_part1
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //create an instance of the class 
            //class with constructor 
            new welcome_voice() { };

            //instance for the logo class with constructor
            new chat_logo() { };

            //creating an instance for a class user_interface
            user_interface user_interfaces = new user_interface();

            //call the method welcoming user
            user_interfaces.welcoming();

            //call the method to ask for the name
            user_interfaces.ask_name();
        }//end of main method
    }//end of class
}//end of namespace