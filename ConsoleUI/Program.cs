using FactoryMethod.Empresas;
using FactoryMethod.Passagens;
using Singleton;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region [Singleton]

            //var cadeira1 = Cadeira.getInstance();
            //cadeira1.Quantidade = 1;

            //var cadeira2 = Cadeira.getInstance();
            //cadeira2.Quantidade = 5;

            //Console.WriteLine(cadeira1.Quantidade.ToString());
            //Console.WriteLine(cadeira2.Quantidade.ToString());
            //Console.ReadLine();

            #endregion

            #region FactoryMethod

            //Empresas de ônibus
            Empresa viacaoABCLocal = new EmpresaOnibusUrbano();
            Empresa viacaoXYZInter = new EmpresaOnibusInterestadual();

            //Emite passagens
            Passagem pUrbano = viacaoABCLocal.emitePassagem("Floramar", "Centro", new DateTime(2017, 8, 10, 11, 0, 0));
            Passagem pInterestadual = viacaoXYZInter.emitePassagem("Minas Gerais", "Rio de Janeiro", new DateTime(2017, 8, 20, 8, 30, 0));

            //Exibe detalhes da passagem
            pUrbano.exibeDetalhes();
            pInterestadual.exibeDetalhes();

            Console.ReadLine();

            #endregion
        }
    }
}
