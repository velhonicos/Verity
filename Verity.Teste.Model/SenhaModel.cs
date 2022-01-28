using System;
using System.Text.RegularExpressions;

namespace Verity.Avaliacao.Model
{
    public class SenhaModel : ValidaCriterio
    {
        public string Caracteres { get; set; }

        public SenhaModel(string caracteres)
        {
            Caracteres = caracteres;
        }

        public override void ValidaTotalCaracteres()
        {
            this.TotalCaracteresValido = Caracteres.Length >= 9;
        }

        public override void ValidaDigito()
        {
            this.DigitoValido = Regex.IsMatch(Caracteres, "[0-9]");
        }

        public override void ValidaMaiuscula()
        {
            this.CaracterMaiusculoValido = Regex.IsMatch(Caracteres, "[A-Z]");
        }

        public override void ValidaMinuscula()
        {
            this.CaracterMinusculoValido = Regex.IsMatch(Caracteres, "[a-z]");
        }

        public override void ValidaCaracterEspecial()
        {
            this.CaracterEspecialValido = Regex.IsMatch(Caracteres, "[!@#$%^&*()-+]");
        }

        public override void ValidaCaracterRepetido()
        {
            this.CaracterRepetidoValido = Regex.IsMatch(Caracteres, @"(\w)*.*\1");
        }                
    }
}
