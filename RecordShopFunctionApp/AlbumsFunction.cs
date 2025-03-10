using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RecordShopFunctionApp.Services;

namespace RecordShopFunctionApp
{
    public  class AlbumsFunction
    {
        public IAlbumsService _albumsService;

        public AlbumsFunction(IAlbumsService albumService)
        {
            _albumsService = albumService;
        }

        [FunctionName("GetAlbums")]
        public async Task<IActionResult> GetAlbums(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "albums")] HttpRequest req)
        {
            var albums =  _albumsService.GetAllAlbums();
            return new OkObjectResult(albums);
        }
       
    }
}
