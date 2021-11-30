using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVBackend.Utilities
{
    public static class Constants
    {
        public static class DatabaseConfig
        {
            public static string Host = "localhost";
            public static string User = "root";
            public static string Password = "";
            public static string Port = "3306";
            public static string Database = "valhallav";
        }

        public static class Positions
        {
            public static readonly Position SpawnPos_Airport = new Position((float)-1045.6615, (float)-2751.1912, (float)21.360474);
            public static readonly Rotation SpawnRot_Airport = new Rotation(0, 0, (float)0.44526514);
        }
    }
}
