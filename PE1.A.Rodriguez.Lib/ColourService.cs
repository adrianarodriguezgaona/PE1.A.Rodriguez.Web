using System;
using System.Collections.Generic;
using System.Text;

namespace PE1.A.Rodriguez.Lib
{

   
    class ColourService
    {


        public enum ColourVariant { Reddish, Greenish, Blueish };
        private static Random rnd = new Random();

        public static void Main()
        {
            
            foreach (string s in GenerateCssColours(10))
                Console.WriteLine(s);
            //IEnumerable<string> grijsColors = GenerateGreyScales(10);
            foreach (string grijs in GenerateGreyScales(10))
                Console.WriteLine(grijs);
        }

        //public ColourVariant Color { get; set; }
        //public string ColorRgb { get; set; }
        //public int NumeroColor { get; set; }

        //public List<ColourService> colourList = new List<ColourService>();

        public static IEnumerable<string> GenerateCssColours(int ammountOfColours)
        {

            for (int i = 0; i < ammountOfColours; i++)
            {
                string rgb = "rgb(" + rnd.Next(0, 256)+"," + rnd.Next(0, 256) + ","+ rnd.Next(0, 256) + ")";                
                       
                yield return rgb;
            }
            
        }
        public static IEnumerable<string> GenerateGreyScales(int ammountOfColours)
        {

            for (int i = 0; i < ammountOfColours; i++)
            {
                int waardeRgb = rnd.Next(0, 256);
                string rgb = "rgb(" + waardeRgb +"," + waardeRgb + ","+ waardeRgb + ")";
                yield return rgb;

            }

        }

        

    }
}