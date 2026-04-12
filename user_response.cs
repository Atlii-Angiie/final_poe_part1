using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;


namespace final_poe_part1
{//start of namespace
    public class user_response
    {//start of class

        //global arrays
        ArrayList container = new ArrayList();
        ArrayList answers = new ArrayList();
        ArrayList ignoring = new ArrayList();

        //method
        public user_response()
        {
            // conversational keywords + improved answers
            container.Add("how are you");
            answers.Add("Thanks for asking! I'm doing great , How about you?");

            container.Add("purpose");
            answers.Add("My purpose is to help you understand cybersecurity and stay safe online in a simple way.");

            container.Add("what can i ask");
            answers.Add("You can ask me about passwords, phishing, viruses, safe browsing, scams, and general online safety tips.");

            // cybersecurity keywords + improved answers
            container.Add("password");
            answers.Add("A strong password should be long (8+ characters) and include uppercase, lowercase, numbers, and symbols to keep it secure.");

            container.Add("phishing");
            answers.Add("Phishing is a scam where attackers pretend to be trusted companies or people to trick you into giving personal information like passwords or bank details.");

            container.Add("cybersecurity");
            answers.Add("Cybersecurity is the practice of protecting your devices, networks, and personal data from online threats and attacks.");

            container.Add("virus");
            answers.Add("A computer virus is a harmful program that can spread and damage your files, steal information, or slow down your system.");

            container.Add("wifi");
            answers.Add("Public Wi-Fi is not secure. Avoid logging into banking or entering passwords when using public networks.");

            container.Add("update");
            answers.Add("Software updates are important because they fix security problems and protect you from new threats and viruses.");
        

        // ignore words
        ignoring.Add("what");
            ignoring.Add("is");
            ignoring.Add("about");
        }

        public void ai_chat(string username)
        {
            string asking = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(username + ": ");
                asking = Console.ReadLine().ToLower();
                Console.ResetColor();

            } while (respond(asking, username));
        }

        private bool respond(string question , string username)
        {
            if (question == "exit")
            {
                Console.WriteLine("CYBERBOT: Bye..." + username + "! , Enjoy the rest of your day");
                return false;
            }

            for (int i = 0; i < container.Count; i++)
            {
                if (question.Contains(container[i].ToString()))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    // custom response with username
                    if (container[i].ToString() == "how are you")
                    {
                        Console.WriteLine("CYBERBOT: I am great , Thanks for asking " + username + ", how about you?");
                    }
                    else
                    {
                        Console.WriteLine("CYBERBOT: " + answers[i]);
                    }

                    Console.ResetColor();
                    return true;
                }
            }

            // default response

            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CYBERBOT : I didn’t quite understand that. Could you rephrase? ");
                Console.ResetColor();
            }

            return true;
        }//end of method
    }//end of class
}//end of namespace
