namespace CustomizeEverything.Events
{
    using Exiled.Events.EventArgs;
    using static Plugin;
    using UnityEngine;
    internal sealed class Handler
    {
        public void OnActivatingGenerator(ActivatingGeneratorEventArgs ev)
        {
            ev.Generator._totalActivationTime = Singleton.Config.GeneratorTime;
            ev.Generator._unlockCooldownTime = 0;
        }
    }
}
