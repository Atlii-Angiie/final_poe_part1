using System;

namespace final_poe_part1
{//start of namespace
    public class user_interface
    {//start of class

        //global variable
        private string username = string.Empty;

        //void method to welcoming the user\

        public void welcoming()
        {
            //start of method
            //display the welcome message with text color
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[WELCOME TO CYBERBOT]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=========================");
            //reset the color to default
            Console.ResetColor();


        }//end of method welcome
        //prompt the user for the username

        public string ask_name()
        {//srat of method

            // ai chat message and name
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CYBERBOT: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hey Enter your name.");
            //rest color
            Console.ResetColor();

            //do while to re-prompt the user
            do
            {//start of do while
                // user prompting with text color
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("User : ");
                //now set the color for when they entering the name
                Console.ForegroundColor = ConsoleColor.DarkRed;
                username = Console.ReadLine();
                //reset color
                Console.ResetColor();

            } while (!isEmpty());

            return username;
            //end of do while
        }
            //THE BOOLEAN METHOD TO CHECK IF THE USER ENTERED NAME
        private Boolean isEmpty()
        { //start of method

            //if statement to check if username is empty or not
            if (username != "")
            {//start of if
                // return success message if not empty
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CYBERBOT: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Hey " + username);
                //return true as they said
                return true;
                


            }//end of if
            else
            {//start of if
                //error message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CYBERBOT : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter your name");

                //return false
                return false;
            }//end of if
    }//end of method ask_name
}//end of class
}//end of namespace