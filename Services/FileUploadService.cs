// FileUploadService.cs file code
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;
using System.Threading.Tasks;

namespace ynex.Services
{
    public class FileUploadService
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var uniqueFileName = Path.Combine(uploadsFolder, file.Name);
            using (var fileStream = new FileStream(uniqueFileName, FileMode.Create))
            {
                await file.OpenReadStream().CopyToAsync(fileStream);
            }

            return Path.GetFileName(uniqueFileName);
        }
    }
}
