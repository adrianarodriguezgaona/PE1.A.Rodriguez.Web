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
           
            foreach (string colores in GenerateCssColours(10, ColourVariant.Reddish)) 
                Console.WriteLine(colores);
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
        public static IEnumerable<string> GenerateCssColours(int ammountOfColours, ColourVariant colourVariant )
        {
            int aantalVarianten = Enum.GetNames(typeof(ColourVariant)).Length;

            for (int i = 0; i < ammountOfColours; i++)
            {
                //for (int j = 0; j < aantalVarianten ; j++)

                //{


                //}

                if (colourVariant == ColourVariant.Blueish)
                {
                    int waardeBlue = rnd.Next(128, 256);
                    int redEnGreen = rnd.Next(0, waardeBlue/2);
                    string rgb = "rgb(" + redEnGreen + "," + redEnGreen + "," + waardeBlue+ ")";
                    yield return rgb;
                }
                if(colourVariant == ColourVariant.Greenish)
                {
                    int waardeGroen = rnd.Next(128, 256);
                    int redEnBlauw = rnd.Next(0, waardeGroen / 2);

                    string rgb = "rgb(" + redEnBlauw + "," + waardeGroen + "," + redEnBlauw + ")";

                    yield return rgb;
                }

                if (colourVariant == ColourVariant.Reddish)
                {
                    int waardeRood = rnd.Next(128, 256);
                    int groenEnBlauw = rnd.Next(0, waardeRood/2);

                    string rgb = "rgb(" + waardeRood + "," + groenEnBlauw + "," + groenEnBlauw + ")";

                    yield return rgb;
                }

            }

        }




    }
}