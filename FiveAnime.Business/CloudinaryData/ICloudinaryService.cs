using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveAnime.Business.CloudinaryData
{
    public interface ICloudinaryService
    {
        public string Image(IFormFile file, string folder);
    }
}
