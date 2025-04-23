using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Services
{
    internal class CriptografiaService
    {
        public string Criptografar(string senha)
        {
            return senha; 
        }

        public string Verificar(string senha, string senhaCriptografada)
        {
            return senha == senhaCriptografada ? "Senha correta" : "Senha incorreta";
        }
    }
}
