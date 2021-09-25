namespace CustomizeEverything
{
    using Exiled.API.Interfaces;
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public float GeneratorTime { get; private set; } = 180;
    }
}
