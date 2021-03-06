using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure;
using Azure.Communication;
using Azure.Communication.Administration;
using Azure.Communication.Administration.Models;

namespace ThoughtStuff.AzureCommsServices
{
    public static class getGroupId
    {




        [FunctionName("getGroupId")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            string _groupID = Environment.GetEnvironmentVariable("GroupId");

            if (String.IsNullOrEmpty(_groupID))
            {
                _groupID = Guid.NewGuid().ToString();
            }

            return new OkObjectResult(_groupID);


        }
    }
}
