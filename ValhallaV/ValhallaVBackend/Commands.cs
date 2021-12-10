using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVBackend
{
    public class Commands : IScript
    {
        [CommandEvent(CommandEventType.CommandNotFound)]
        public static void CommandNotFound(IPlayer player, string command)
        {
            player.SendChatMessage("Command " + command + " nicht gefunden!");
            return;
        }

        [Command("veh")]
        public static void SpawnVehicle(IPlayer player, string vehName)
        {
            IVehicle veh = Alt.CreateVehicle(Alt.Hash(vehName), new Position(player.Position.X, player.Position.Y + 2.25f, player.Position.Z), player.Rotation);
            veh.NumberplateText = "Sinaloa";
            veh.EngineOn = true;
            veh.LockState = VehicleLockState.Unlocked;
        }

        [Command("pos")]
        public static void ShowPlayerPosition(IPlayer player)
        {
            player.SendChatMessage($"{player.Position}");
            Alt.Log($"{player.Position}");
        }

        [Command("rot")]
        public static void ShowPlayerRotation(IPlayer player)
        {
            player.SendChatMessage($"{player.Rotation}");
            Alt.Log($"{player.Position}");
        }
    }
}
