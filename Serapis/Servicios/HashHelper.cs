using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Serapis.Servicios
{
    public static class HashHelper
    {
        public static string CalcularHash(string texto)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(texto);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool VerificarHash(string textoPlano, string hashExistente)
        {
            var hashTextoPlano = CalcularHash(textoPlano);
            return hashTextoPlano == hashExistente;
        }
    }
}

