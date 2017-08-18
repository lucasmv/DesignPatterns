namespace Singleton
{
    public class Cadeira
    {
        private static readonly Cadeira instance = new Cadeira();

        public int Quantidade { get; set; }

        private Cadeira() { }

        public static Cadeira getInstance()
        {
            return instance;
        }
    }
}
