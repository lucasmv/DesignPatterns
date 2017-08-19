using AbstractFactory.Passagens;
using System;

namespace AbstractFactory.Empresa
{
    public class EmpresaOnibus : Empresa
    {
        public override PassagemOnibusInterestadual emitePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }

        public override PassagemOnibusUrbano emitePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
