using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using FunctionApp.AppSettings;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;

namespace FunctionApp
{
    public static class PostTrailFuction
    {
        private static ILogger _log;

        [FunctionName("PostTrailFuction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            _log = log;
        log.LogInformation("C# HTTP trigger function processed a request.");
            

            var dict = new Dictionary<string, string>();
            int trail;

            try
            {
                GetParameter(req, "name", dict);
                GetParameter(req, "lang", dict);             
                GetParameter(req, "min", dict);
                GetParameter(req, "hint", dict);
                GetParameter(req, "email", dict);
                GetParameter(req, "trail", dict);

                trail = CastString(req.Query["trail"]);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("Failed to read Parameters. " + ex.Message);
            }

            string html;
            try
            {
                var closest = TrailRepository.GetTwoClosestGames(TrailRepository.GetTrail(trail));
                var trailObject = TrailRepository.GetTrail(trail);

                var htmlFactory = new HtmlFactoryService();
                html = htmlFactory.MakeTicketConfirmation(dict, trailObject.City, trailObject.MapsLink, trailObject.TripAdvisorLink, closest[0].City,
                    closest[1].City, closest[0].Image, closest[1].Image, closest[0].LinkGame, closest[1].LinkGame);
            }
            catch(Exception ex)
            { 
                return new BadRequestObjectResult("Failed to create HTML. " + ex.Message);
            }


            try
            {
                var mailSettings = ConfigFactory.GetTestSettings();
                var mySender = new Sender(mailSettings.Email, mailSettings.Password);
                bool IsSend = mySender.EmailSender(html, dict["email"]);
                return new OkObjectResult("ok email send");
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("Failed at sending Email " + ex.Message);
            }
          
        }

        private static int CastString(string stringParameter)
        {
            var result = int.TryParse(stringParameter, out int intResult);

            if (result)
            {
                return intResult;
            }

            var erroMsg = $"Cannot parse string {stringParameter} to an int";

            _log.LogError(erroMsg);

            throw new Exception(erroMsg);
        }

        
        private static void GetParameter(HttpRequest req, string parameterName, Dictionary<string, string> dict)
        {
            var result = req.Query[parameterName];
            
            if (string.IsNullOrEmpty(result))
            {
                throw new Exception($"Cannot find parameter: {parameterName}");
            }
            
            dict.Add(parameterName, result);
        }
        
        

    }
}
