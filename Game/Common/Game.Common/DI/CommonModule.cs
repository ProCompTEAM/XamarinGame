using BoDi;

namespace Game.Common.DI
{
    public static class CommonModule
    {
        public static IObjectContainer Container { get; } = new ObjectContainer();
    }
}
