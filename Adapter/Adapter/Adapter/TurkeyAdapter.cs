namespace Adapter
{
    internal class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this._turkey = turkey;
        }

        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}