using Xunit;

namespace Verity.Avaliacao.Model.Test
{
    public class SenhaServiceTest
    {
        [InlineData("123456789")]
        [Theory]
        //[Fact]
        public void ValidaTotalCaracteresSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);

            //act
            senha.ValidaTotalCaracteres();
            
            //assert
            Assert.True(senha.TotalCaracteresValido);
        }

        [InlineData("123456")]
        [Theory]
        public void ValidaTotalCaracteresComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);            
            
            //act
            senha.ValidaTotalCaracteres();

            //assert
            Assert.True(senha.TotalCaracteresValido);
        }

        [InlineData("123456As@")]
        [Theory]
        public void ValidaDigitoSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);            
            
            //act
            senha.ValidaDigito();
            
            //assert
            Assert.True(senha.DigitoValido);
        }

        [InlineData("fdjakshfg")]
        [Theory]
        public void ValidaDigitoComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);            
            //act
            senha.ValidaTotalCaracteres();

            //assert
            Assert.True(senha.DigitoValido);
        }

        [InlineData("ABDFK@")]
        [Theory]
        public void ValidaMaiusculaSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);

            //act
            senha.ValidaMaiuscula();

            //assert
            Assert.True(senha.CaracterMaiusculoValido);
        }

        [InlineData("fsdf")]
        [Theory]
        public void ValidaMaiusculaComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);
            
            //act
            senha.ValidaMaiuscula();

            //assert
            Assert.True(senha.CaracterMaiusculoValido);
        }

        [InlineData("fs42354")]
        [Theory]
        public void ValidaMinusculaSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);

            //act
            senha.ValidaMinuscula();

            //assert
            Assert.True(senha.CaracterMinusculoValido);
        }

        [InlineData("DJ45636")]
        [Theory]
        public void ValidaMinusculaComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);
            
            //act
            senha.ValidaMinuscula();

            //assert
            Assert.True(senha.CaracterMinusculoValido);
        }


        [InlineData("fs42@#354")]
        [Theory]
        public void ValidaCaracterEspecialSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);

            //act
            senha.ValidaCaracterEspecial();

            //assert
            Assert.True(senha.CaracterEspecialValido);
        }

        [InlineData("DJfsd45636")]
        [Theory]
        public void ValidaCaracterEspecialComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);
            
            //act
            senha.ValidaCaracterEspecial();

            //assert
            Assert.True(senha.CaracterEspecialValido);
        }


        [InlineData("fs4235")]
        [Theory]
        public void ValidaCaracterRepetidoSemErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);

            //act
            senha.ValidaCaracterRepetido();

            //assert
            Assert.False(senha.CaracterEspecialValido);
        }

        [InlineData("DJfsd45636")]
        [Theory]
        public void ValidaCaracterRepetidoComErros(string Caracteres)
        {
            //arrange
            SenhaModel senha = new SenhaModel(Caracteres);
            //act
            senha.ValidaCaracterRepetido();

            //assert
            Assert.True(senha.CaracterEspecialValido);
        }
    }
}
