using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVBackend.Model
{
    public partial class Accounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string playerName { get; set; }
        public string email { get; set; }
        public ulong socialClub { get; set; }
        public ulong hardwareId { get; set; }
        public string password { get; set; }
        public int online { get; set; }
        public bool whitelisted { get; set; }
        public bool ban { get; set; }
        public string banReason { get; set; }
        public int adminLevel { get; set; }
    }
}
