using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.A.Rodriguez.Lib;

namespace PE1.A.Rodriguez.Web.Controllers
{
    public class ColourController : Controller
    {
        public IActionResult Index(int amountOfColours = 10)
        {
            var cssColours = new ColourService();
           
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"<h2>10 kleuren</h2>");
            foreach (string s in ColourService.GenerateCssColours(10))
            {
                stringBuilder.AppendLine($"<div style =\"width:75px; height:50px; display:inline-block; background:{s};\"></div>");
            }
            stringBuilder.AppendLine($"<h2>10 tinten grijs</h2>");
            foreach (string grijs in ColourService.GenerateGreyScales(10))
            {
                stringBuilder.AppendLine($"<div style =\"width:75px; height:50px; background:{grijs} ; display:inline-block;\"></div>");
            }
            stringBuilder.AppendLine($"<h2>Kleur variaties (Rood, Groen en Blauw)</h2>");

            foreach (string rood in ColourService.GenerateCssColours(10, ColourService.ColourVariant.Reddish))
            {
                stringBuilder.AppendLine($"<div style =\"width:75px; height:50px; background:{rood} ; display:inline-block;\"></div>");
            }
            stringBuilder.AppendLine($"</br>");
            foreach (string rood in ColourService.GenerateCssColours(10, ColourService.ColourVariant.Greenish))
            {
                stringBuilder.AppendLine($"<div style =\"width:75px; height:50px; background:{rood} ; display:inline-block;\"></div>");
            }
            stringBuilder.AppendLine($"</br>");
            foreach (string rood in ColourService.GenerateCssColours(10, ColourService.ColourVariant.Blueish))
            {
                stringBuilder.AppendLine($"<div style =\"width:75px; height:50px; background:{rood} ; display:inline-block;\"></div>");
            }

            return Content(stringBuilder.ToString(), "text/html");
        }
    }
}
