using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SispeServicios.Archivo.S3
{
    public class ResponseDto
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string FileNameRespository { get; set; }
        public Stream FileStream { get; set; }
    }
}
