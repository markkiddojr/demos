using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AzureFunctionsDemo.Functions
{
    public static class BlazorDemoStateHttpTrigger
    {
        private enum State { Intro, CoreVsFramework, WhatIsFunctions, ChangesInArchitecture, Blazor, WhyServerless }
        
        [FunctionName("BlazorDemoStateHttpTrigger")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            bool back = req.Query["back"].ToString().Trim().ToLower() == "true";

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var resp = JObject.Parse(requestBody);
            var data = Enum.Parse<State>(resp["state"].ToString().Replace("State.",""));
            switch (data)
            {
                case State.Intro:
                    return new OkObjectResult((back) ? State.Intro : State.CoreVsFramework);
                case State.CoreVsFramework:
                    return new OkObjectResult((back) ? State.Intro : State.WhatIsFunctions);
                case State.WhatIsFunctions:
                    return new OkObjectResult((back) ? State.CoreVsFramework : State.ChangesInArchitecture);
                case State.ChangesInArchitecture:
                    return new OkObjectResult((back) ? State.WhatIsFunctions : State.Blazor);
                case State.Blazor:
                    return new OkObjectResult((back) ? State.ChangesInArchitecture : State.WhyServerless);
                case State.WhyServerless:
                    return new OkObjectResult((back) ? State.Blazor : State.WhyServerless);
                default:
                    break;
            }

            return new BadRequestObjectResult("Please pass a slide state via the request body and query parameter to indicate true or false if you are going back a page.");
        }
    }
}
