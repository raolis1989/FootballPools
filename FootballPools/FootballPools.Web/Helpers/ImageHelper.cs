using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FootballPools.Web.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadingImageAsync(IFormFile imageFile, string folder)
        {
            string guid = Guid.NewGuid().ToString();
            string file = $"{guid}.jpg";
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot\\images\\{folder}",
                file);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            return $"~/images/{folder}/{file}";

        }
    }
}
