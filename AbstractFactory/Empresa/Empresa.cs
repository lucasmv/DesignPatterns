using AbstractFactory.Passagens;
using System;

namespace AbstractFactory.Empresa
{
    public abstract class Empresa
    {
        public abstract PassagemOnibusUrbano emitePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida);
        public abstract PassagemOnibusInterestadual emitePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida);
    }
}
