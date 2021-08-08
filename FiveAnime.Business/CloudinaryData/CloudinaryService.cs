using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace FiveAnime.Business.CloudinaryData
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary) => this.cloudinary = cloudinary;

        public string Image(IFormFile file, string folder)
        {
            byte[] fileBytes;
            UploadResult uploadResult = null;

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                fileBytes = memoryStream.ToArray();
            }

            using (var memoryStream = new MemoryStream(fileBytes))
            {
                ImageUploadParams uploadParams = new ImageUploadParams
                {
                    Folder = folder,
                    File = new FileDescription($"{DateTime.UtcNow} - {file.Name}", memoryStream),
                };

                uploadResult = cloudinary.Upload(uploadParams);
            }

            return uploadResult?.SecureUri.AbsoluteUri;
        }

        public string Video(IFormFile file, string folder)
        {
            byte[] fileBytes;
            UploadResult uploadResult = null;

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                fileBytes = memoryStream.ToArray();
            }

            using (var memoryStream = new MemoryStream(fileBytes))
            {
                RawUploadParams uploadParams = new RawUploadParams
                {
                    Folder = folder,
                    File = new FileDescription($"{DateTime.UtcNow} - {file.Name}", memoryStream)
                };

                uploadResult = cloudinary.Upload(uploadParams);
            }

            return uploadResult?.SecureUrl.AbsoluteUri;
        }
    }
}