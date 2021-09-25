namespace CustomizeEverything
{
    using CustomizeEverything.Events;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using System;
    using Player = Exiled.Events.Handlers.Player;
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        private Handler handler;
        public override string Author { get; } = "Cegla";
        public override string Name { get; } = "CustomizeEverything";
        public override string Prefix { get; } = "CustomizeEverything";
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        public override Version Version { get; } = new Version(1, 0, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Highest;

        public override void OnEnabled()
        {
            Singleton = this;
            RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Singleton = null;
            UnregisterEvents();
            base.OnDisabled();
        }
        public void RegisterEvents()
        {
            handler = new Handler();
            Player.ActivatingGenerator += handler.OnActivatingGenerator;
        }
        public void UnregisterEvents()
        {
            handler = null;
            Player.ActivatingGenerator -= handler.OnActivatingGenerator;
        }
    }

}
