using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    public static class CriptografiaService
    {
        public static string Criptografar(string senha)
        {
            var password = BCrypt.Net.BCrypt.HashPassword(senha);
            return password; 
        }

        public static bool Verificar(string senha, string senhaCriptografada)
        {
            return BCrypt.Net.BCrypt.Verify(senha, senhaCriptografada);
        }
    }
}
