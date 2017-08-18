using FactoryMethod.Passagens;
using System;

namespace FactoryMethod.Empresas
{
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
