using System;
using System.Drawing;

namespace final_poe_part1
{//start of namespace
    public class chat_logo
    {//start of class

        //get the path of where the project and logo is
        string path_logo = AppDomain.CurrentDomain.BaseDirectory;


        public chat_logo()
        {//start of constructor
            //call the method to display the logo
            display_logo();
        }//end of constructor

        //method to display the logo

        private void display_logo()
        {//start of method
            //replace bin and debug -> bin\Debug
            string full_path = path_logo.Replace(@"\bin\Debug\", @"\logo.jpg");
            Console.WriteLine(full_path);

            //path of the logo [ where the logo is ]
            string path = full_path;

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 150;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#S%?*+;:,. ";

            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            
        }
    }//end of method
    }//end of class
}//end of namespace
