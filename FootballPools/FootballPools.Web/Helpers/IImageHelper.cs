using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballPools.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadingImageAsync(IFormFile imageFile, string folder);
    }
}
