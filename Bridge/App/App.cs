using Bridge.API;

namespace Bridge.App
{
    abstract class App
    {
        public ISendAPI SendAPI;

        public abstract void Send();
    }
}
