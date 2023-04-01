using System;
using System.Collections.Generic;

namespace SignalRChatRoom.Entities
{
    public class GroupList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Messages> Member { get; set; }
        public string Pic { get; set; }

        
    }
}
