using System;

namespace FactoryMethod.Passagens
{
    public class PassagemOnibusInterestadual : Passagem
    {
        public PassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }

        public override void exibeDetalhes()
        {
            Console.WriteLine(string.Format("Passagem de ônibus interestadual: {0} para {1}, Data/Hora: {2}", Origem, Destino, DataHoraPartida));
        }
    }
}
