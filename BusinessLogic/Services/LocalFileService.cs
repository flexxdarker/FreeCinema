using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LocalFileService : IFileService
    {
        private const string imageFolder = "images";
        private readonly IWebHostEnvironment environment;

        public LocalFileService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public Task DeleteProductImage(string path)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SaveFilmImage(IFormFile file)
        {


            // get image destination path
            //string root = environment.WebRootPath;      // wwwroot
            //string name = Guid.NewGuid().ToString();    // random name
            //string extension = Path.GetExtension(file.FileName); // get original extension
            //string fullName = name + extension;         // full name: name.ext

            //Directory.CreateDirectory(Path.Combine(root, imageFolder));

            //// create destination image file path
            //string imagePath = Path.Combine(imageFolder, fullName);
            //string imageFullPath = Path.Combine(root, imagePath);

            //// save image on the folder
            //using (FileStream fs = new FileStream(imageFullPath, FileMode.Create))
            //{
            //    await file.CopyToAsync(fs);
            //}

            // return image file path
            return "https://www.wallpapers13.com/wp-content/uploads/2015/12/Nature-Lake-Bled.-Desktop-background-image-840x525.jpg"; //Path.DirectorySeparatorChar + imagePath;
        }
    }
}
