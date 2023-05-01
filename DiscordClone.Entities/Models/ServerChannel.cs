using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordClone.Entities.Models
{
    public class ServerChannel
    {
        public List<User>? ActiveUsers { get; set; }
        //TODO : Add properties for the chat windows in a server. Maybe make a chat data type
        //TODO : Add a bool to see if a channel is audio or text

    }
}
