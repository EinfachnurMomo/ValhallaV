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

        }

        public override void OnStop()
        {
            foreach (var player in Alt.GetAllPlayers().Where(p => p != null && p.Exists)) player.Kick("Server wird gestoppt..");
            Alt.Log("Server wurde gestoppt!");
        }
    }
}
