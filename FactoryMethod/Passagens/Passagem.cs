using System;

namespace FactoryMethod.Passagens
{
    public abstract class Passagem
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }

        public Passagem(string origem, string destino, DateTime dataHoraPartida)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.DataHoraPartida = dataHoraPartida;
        }

        public abstract void exibeDetalhes();
    }
}
