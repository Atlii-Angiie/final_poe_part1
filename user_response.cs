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
        {//start of method 

            // conversational keywords + answers
            container.Add("how are you");
            answers.Add("I’m doing great, thanks for asking! How about you?");

            container.Add("purpose");
            answers.Add("I’m here to help you learn about cybersecurity and safe online practices.");

            container.Add("what can i ask");
            answers.Add("You can ask me about passwords, phishing, safe browsing, viruses, and online safety tips.");

            // cybersecurity keywords + answers
            container.Add("password");
            answers.Add("A strong password should be at least 8 characters long and include letters, numbers, and symbols.");

            container.Add("phishing");
            answers.Add("Phishing is a trick used by attackers where they pretend to be someone you trust to steal your personal information.");

            container.Add("cybersecurity");
            answers.Add("Cybersecurity is about protecting your devices and personal data from online threats.");

            container.Add("virus");
            answers.Add("A computer virus is a harmful program that can damage your system or steal your data.");

            container.Add("wifi");
            answers.Add("Avoid using public Wi-Fi for sensitive activities like banking because it is not secure.");

            container.Add("update");
            answers.Add("Keeping your software updated helps protect you from new security threats.");

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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(username + ": ");
                asking = Console.ReadLine().ToLower();
                Console.ResetColor();

            } while (respond(asking));
        }

        private bool respond(string question)
        {
            if (question == "exit")
            {
                Console.WriteLine("CYBERBOT: Bye...");
                return false;
            }

            string[] words = question.Split(' ');
            bool found = false;

            foreach (string word in words)
            {
                if (ignoring.Contains(word))
                    continue;

                for (int i = 0; i < container.Count; i++)
                {
                    if (word.Contains(container[i].ToString()))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("CYBERBOT: " + answers[i]);
                        Console.ResetColor();

                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }

            // default response
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase? ");
                Console.ResetColor();
            }

            return true;
        }
    }
}//end of namespace
