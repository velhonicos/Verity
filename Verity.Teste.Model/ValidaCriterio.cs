using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verity.Avaliacao.Model
{
    public abstract class ValidaCriterio
    {
        private bool _digitoValido;
        private bool _totalCaracteresValido;
        private bool _caracterMinusculoValido;
        private bool _caracterMaiusculoValido;
        private bool _caracterEspecialValido;
        private bool _caracterRepetidoValido;

        public bool DigitoValido
        {
            get
            {
                return _digitoValido;
            }
            set
            {
                _digitoValido = value;
            }
        }

        public bool TotalCaracteresValido
        {
            get
            {
                return _totalCaracteresValido;
            }
            set
            {
                _totalCaracteresValido = value;
            }
        }

        public bool CaracterMinusculoValido
        {
            get
            {
                return _caracterMinusculoValido;
            }
            set
            {
                _caracterMinusculoValido = value;
            }
        }

        public bool CaracterMaiusculoValido
        {
            get
            {
                return _caracterMaiusculoValido;
            }
            set
            {
                _caracterMaiusculoValido = value;
            }
        }

        public bool CaracterEspecialValido
        {
            get
            {
                return _caracterEspecialValido;
            }
            set
            {
                _caracterEspecialValido = value;
            }
        }

        public bool CaracterRepetidoValido
        {
            get
            {
                return _caracterRepetidoValido;
            }
            set
            {
                _caracterRepetidoValido = value;
            }
        }

        public abstract void ValidaTotalCaracteres();
        public abstract void ValidaDigito();
        public abstract void ValidaMinuscula();
        public abstract void ValidaMaiuscula();
        public abstract void ValidaCaracterEspecial();
        public abstract void ValidaCaracterRepetido();
    }
}
