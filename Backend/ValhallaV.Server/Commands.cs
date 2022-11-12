using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltV.Net.Enums;

namespace ValhallaV.Server
{
    public class Commands : IScript
    {
        [Command("veh")]
        public static void OnPlayerCommandCreateVehicle(IPlayer player, string vehName, byte r = 0, byte g = 0, byte b = 0, byte r2 = 0, byte g2 = 0, byte b2 = 0, string plateText = "AltV")
        {
            IVehicle veh = Alt.CreateVehicle(Alt.Hash(vehName), new Position(player.Position.X, player.Position.Y + 1.5f, player.Position.Z - 1.0f), player.Rotation);
            veh.PrimaryColorRgb = new Rgba(r, g, b, 255);
            veh.SecondaryColorRgb = new Rgba(r2, g2, b2, 255);
            veh.NumberplateText = plateText;
            if (veh != null) player.SendChatMessage($"{vehName} gespawnt!");
        }

        [Command("gun")]
        public static void OnPlayerCommandGiveWeapon(IPlayer player, WeaponModel weaponName, int ammo)
        {
            player.GiveWeapon(weaponName, ammo, true);
        }

        [Command("ped")]
        public static void OnPlayerCommandChangePedModel(IPlayer player, PedModel pedModel)
        {
            player.Model = (uint)pedModel;
        }

        [Command("pos")]
        public static void OnPlayerCommandGetPosition(IPlayer player)
        {
            if (player.IsInVehicle)
            {
                player.SendChatMessage($"{player.Vehicle.Position} {player.Vehicle.Rotation}");
                Alt.Log($"{player.Vehicle.Position} {player.Vehicle.Rotation}");
            }
            else
            {
                Alt.Log($"{player.Position}");
                player.SendChatMessage($"{player.Position}");
            }
        }
    }
}
