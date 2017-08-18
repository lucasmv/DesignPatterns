using FactoryMethod.Passagens;
using System;

namespace FactoryMethod.Empresas
{
    public abstract class Empresa
    {
        public abstract Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida);
    }
}
