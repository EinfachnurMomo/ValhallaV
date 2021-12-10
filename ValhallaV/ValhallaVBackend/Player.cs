using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace ValhallaVBackend
{
    public class Player : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(IPlayer player, string reason)
        {
            player.SetDateTime(DateTime.Now);
            player.Model = (uint)PedModel.Agent;
            //player.SetPosition(147.170f, -2201.804f, 4.688f);
            player.Spawn(new Position(480.46155f, -1562.7296f, 29.246094f));

            IVehicle veh = Alt.CreateVehicle(Alt.Hash("dubsta2"), new Position(477.0066f, -1568.5319f, 29.043945f), new Rotation(0, 0, 0));
            veh.NumberplateText = "Sinaloa";
        }

        [ScriptEvent(ScriptEventType.PlayerDead)]
        public static void OnPlayerDeath(IPlayer player, IPlayer killer, uint weapon)
        {
            //player.Spawn(new Position(147.170f, -2201.804f, 4.688f));
            player.Spawn(new Position(480.46155f, -1562.7296f, 29.246094f));
        }

        [ScriptEvent(ScriptEventType.PlayerEnterVehicle)]
        public static void PlayerEnterVehicle(IPlayer[] player, IVehicle veh, byte seat)
        {
            veh.SetSyncedMetaData("FUEL", 50);
            Alt.EmitClients(player, "speedometer:show", veh);
        }

        [ScriptEvent(ScriptEventType.PlayerLeaveVehicle)]
        public static void PlayerLeaveVehicle(IPlayer[] player, IVehicle veh, byte seat)
        {
            Alt.EmitClients(player, "speedometer:hide", veh);
        }
    }
}
