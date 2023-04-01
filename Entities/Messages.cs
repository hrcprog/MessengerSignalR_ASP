using System;

namespace SignalRChatRoom.Entities
{
    public class Messages
    {
        public long Id { get; set; }
        public long SenderId { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }

        /// <summary>
        /// status - 0:sent, 1:delivered, 2:read
        /// </summary>
        public int Status { get; set; }
        public long RecvId { get; set; }
        public long RecvIsGroup { get; set; }
    }
}
