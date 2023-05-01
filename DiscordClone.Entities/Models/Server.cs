using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordClone.Entities.Models
{
    public class Server
    {
        public List<User> Users { get; set; }
        public List<ServerChannel>? ServerChannels { get; set; }

        //TODO : Add References for channels 

    }
}
