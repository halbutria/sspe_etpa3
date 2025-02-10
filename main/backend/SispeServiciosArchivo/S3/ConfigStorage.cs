using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SispeServicios.Archivo.S3
{
    public class ConfigStorage
    {
        public string FileName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Repository { get; set; }
        public IFormFile? File { get; set; }
    }
}
 