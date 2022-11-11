using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaV.Server
{
    public class Commands : IScript
    {
        [Command("veh")]
        public static void OnPlayerSpawnVehicle(IPlayer player, string vehName, byte r = 0, byte g = 0, byte b = 0, byte a = 255)
        {
            IVehicle veh = Alt.CreateVehicle(Alt.Hash(vehName), new Position(player.Position.X, player.Position.Y + 1.5f, player.Position.Z), player.Rotation);
            veh.PrimaryColorRgb = new Rgba(r, g, b, a);
            if (veh != null) player.SendChatMessage($"{vehName} gespawnt!");
        }
    }
}
