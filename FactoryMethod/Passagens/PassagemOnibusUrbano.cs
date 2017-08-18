using System;

namespace FactoryMethod.Passagens
{
    public class PassagemOnibusUrbano : Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }

        public override void exibeDetalhes()
        {
            Console.WriteLine(string.Format("Passagem de ônibus urbana: {0} para {1}, Data/Hora: {2}", Origem, Destino, DataHoraPartida));
        }
    }
}
