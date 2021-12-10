using System;
using System.Linq;
using System.Threading;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace ValhallaVBackend
{
    public class Main : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Server wurde gestartet!");
        }

        public override void OnStop()
        {
            Alt.Log("Server wurde gestoppt!");
        }
    }
}
