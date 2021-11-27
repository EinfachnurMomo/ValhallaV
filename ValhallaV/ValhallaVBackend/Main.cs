using System;
using AltV.Net;

namespace ValhallaVBackend
{
    public class Main : Resource
    {
        public override void OnStart()
        {
            Alt.Log("ValhallaV gestartet.");
        }

        public override void OnStop()
        {
            Alt.Log("ValhallaV gestoppt!");
        }
    }
}
