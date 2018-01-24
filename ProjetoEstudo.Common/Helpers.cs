using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Common
{
    public class Helpers
    {
        public static void ForNullOrEmpty(string value, string mensagemErro)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception(mensagemErro);
        }
    }
}