using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltV.Net.Resources.Chat.Api;

namespace ValhallaV.Server
{
    public class Player : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(IPlayer player, string reason)
        {
            player.SetDateTime(DateTime.UtcNow);
            player.Model = (uint)PedModel.Chef;
            player.SetPosition(-365.425f, -131.809f, 37.873f);
        }

        [ScriptEvent(ScriptEventType.PlayerDead)]
        public static void OnPlayerDeath(IPlayer player, IEntity killer, uint weapon)
        {
            player.Model = (uint)PedModel.Zombie01;
            player.Spawn(new Position(-365.425f, -131.809f, 37.873f));
        }

        [ScriptEvent(ScriptEventType.PlayerEnterVehicle)]
        public static void OnPlayerEnterVehicle(IVehicle vehName, IPlayer player, byte seat)
        {
            player.SendChatMessage($"Du bist eingestiegen auf Platz {seat}.");
        }

        [ScriptEvent(ScriptEventType.PlayerDamage)]
        public static void OnPlayerDamage(IPlayer player, IEntity attacker, uint weapon, ushort healthDamage, ushort armourDamage)
        {
            player.SendChatMessage($"Spieler: {player.Name}");
            player.SendChatMessage($"Schaden: Leben: -{healthDamage}");
            player.SendChatMessage($"Rüstung: -{armourDamage}");
            player.SendChatMessage($"Angreifer: {attacker}");
            player.SendChatMessage($"Waffe: {weapon}");
            player.SendChatMessage($"-----------------------------");
        }
    }
}
