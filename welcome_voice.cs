using System;
using System.Dynamic;
using System.IO;
using System.Media; 

namespace final_poe_part1
{// start of namespace
    public  class welcome_voice
    {//start of class
     //auto path 
        string path = AppDomain.CurrentDomain.BaseDirectory;
        public welcome_voice()
        {//start of constructor
            //call the method to play the voice
            play_voice();
        }//end of constructor

       //method to voice greet the user
       private void play_voice()
        {//start of method

            //get the full path replace the bin\Debug\net472\ with the path to the wav file
            //use template string to replace the path
            //uing a replace function
            string full_path = path.Replace(@"bin\Debug\", "");

            //play the sound 
            string joined_path = full_path + "welcome.wav";

            //create a instance for the soundplayer class
            SoundPlayer player = new SoundPlayer(joined_path);

            //load the audio
            player.Load();

            //play till 
            player.PlaySync();

        }//end of method
    }//end of class
}//end of namespace