﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace ValhallaV.Server
{
    public class Server : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Server wird gestartet..");

            Alt.Log("Server gestartet!");
        }

        public override void OnStop()
        {
            Alt.Log("Server beendet!");
        }
    }
}
