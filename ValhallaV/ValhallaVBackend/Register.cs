using AltV.Net;
using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVBackend
{
    class RegisterHandler : IScript
    {
        [ClientEvent("Server:Register:RegisterPlayer")]
        public async void RegisterPlayer(IPlayer player, string username, string email, string pass, string passrepeat)
        {
        }
    }
}
