using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaV.Server
{
    public class Player : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void OnPlayerConnect(IPlayer player, string reason)
        {
            player.SetDateTime(DateTime.UtcNow);
            player.Model = (uint)PedModel.Chef;
            player.SetPosition(-365.425f, -131.809f, 37.873f);
        }

        [ScriptEvent(ScriptEventType.PlayerDead)]
        public void OnPlayerDeath(IPlayer player, IPlayer killer, uint weapon)
        {
            player.Model = (uint)PedModel.Zombie01;
            player.Spawn(new Position(-365.425f, -131.809f, 37.873f));
        }
    }
}
