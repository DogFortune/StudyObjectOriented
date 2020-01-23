namespace ConsoleApp1.Types
{
    public abstract class Engine
    {
        protected Engine() { }
        public abstract void On();

        public abstract void Off();

        public abstract int RotationalSpeed { get; }
    }
}
