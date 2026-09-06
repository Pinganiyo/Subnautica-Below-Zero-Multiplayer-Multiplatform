namespace Subnautica.Events.EventArgs
{
    using System;

    public class InGameMenuSaveGameEventArgs : EventArgs
    {
        public bool IsHandled { get; set; } = true;
    }
}
