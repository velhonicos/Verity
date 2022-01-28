using Verity.Avaliacao.Model;

namespace Verity.Avaliacao.Api.Services.Interface
{
    public interface ISenhaService
    {
        bool ValidaSenha(SenhaModel senha);
    }
}
