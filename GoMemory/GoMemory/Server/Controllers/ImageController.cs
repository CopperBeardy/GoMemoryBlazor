using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders.Internal;


namespace GoMemory.Server.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        

        // not workign just some play code
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dPath = Path.Combine("wwwroot", "images");
            PhysicalDirectoryContents images = new PhysicalDirectoryContents(dPath);
           
            return (IActionResult)images ;
        }
    }
}
