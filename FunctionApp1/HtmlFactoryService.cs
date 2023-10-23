using System;
using System.Collections.Generic;
using System.IO;

namespace FunctionApp
{
    public class HtmlFactoryService
    {
        public string MakeTicketConfirmation(Dictionary<string, string> dict,string city ,string Google, string Trip,
     string NextTrail1, string NextTrail2, string Nextimage, string Nextimage2, string Nextlink, string Nextlink2)
        {
            var file = SelectFile(dict["lang"]);
            var body = ReadFileAsync(file);
       
            var replacements = new Dictionary<string, string>
            {
                 { "PLAYERNAME", dict["name"] },
                 { "GAMENAME", city },
                 { "Min", dict["min"] },
                 { "hints", dict["hint"] },
                 { "Google", Google },
                 { "Trip", Trip },
                 { "Near", NextTrail1 },
                 { "Near2", NextTrail2 },
                 { "Imagenear", Nextimage },
                 { "Imagenear2", Nextimage2 },
                 { "link", Nextlink },
                 {"link2", Nextlink2 }
             };

            foreach (var replacement in replacements)
            {
                body = ReplaceInText(body, replacement.Key, replacement.Value);
            }

            return body;
        }

        private string SelectFile(string language)
        {
            switch (language)
            {
                case "en":
                    return "index.html";

                case "de":
                    return "index.html"; //ToChange

                case "it":
                    return "index.html"; //ToChange
            }

            var exceptionMsg = $"There is not Ticket Template for Language {language}";
            throw new Exception(exceptionMsg);
        }

        private string ReadFileAsync(string fileName)
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\EmailTemplates\" + fileName;
            return File.ReadAllText(path);
        }

        private string ReplaceInText(string text, string oldString, string newString)
        {
            const string prefix = "[[";
            const string suffix = "]]";

            oldString = prefix + oldString + suffix;

            return text.Replace(oldString, newString);
        }


    }

}
