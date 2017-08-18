using FactoryMethod.Passagens;
using System;

namespace FactoryMethod.Empresas
{
    public class EmpresaOnibusInterestadual : Empresa
    {
        public override Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }
    }
}
