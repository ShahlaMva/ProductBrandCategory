﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Watch.Extentions
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool ImageSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }

        public static async Task<string> CopyImage(this IFormFile file, string root, string folder)
        {
            string path = root;
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = System.IO.Path.Combine(path, folder, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);

            };
            return (fileName);
        }
    }
}
