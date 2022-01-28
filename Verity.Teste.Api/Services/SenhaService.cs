using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verity.Avaliacao.Api.Services.Interface;
using Verity.Avaliacao.Model;

namespace Verity.Avaliacao.Api.Services
{
    public class SenhaService : ISenhaService
    {
        public bool ValidaSenha(SenhaModel senha)
        {
            senha.ValidaTotalCaracteres();
            senha.ValidaMinuscula();
            senha.ValidaMaiuscula();
            senha.ValidaDigito();
            senha.ValidaCaracterEspecial();
            senha.ValidaCaracterRepetido();

            if (senha.TotalCaracteresValido && senha.CaracterMinusculoValido && senha.CaracterMaiusculoValido && senha.DigitoValido && senha.CaracterEspecialValido && !senha.CaracterRepetidoValido)
                return true;
            else
                return false;
        }
    }
}
