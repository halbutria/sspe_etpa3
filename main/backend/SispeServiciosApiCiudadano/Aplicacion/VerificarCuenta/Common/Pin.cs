using System.Security.Cryptography;
using System.Text;

namespace SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta.Common
{
    public static class Pin
    {
        public static (uint pin, long key) crear (string email, long key = 0)
        {
            key = (key != 0) ? key : DateTime.Now.GetHashCode();
            string str = $"{email};{key}";
            byte[] encoded = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
            var pin = BitConverter.ToUInt32(encoded, 0) % 1000000;
            return (pin, key);
        }
    }
}
