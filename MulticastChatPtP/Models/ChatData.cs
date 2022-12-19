using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastChatPtP.Models
{
    [Serializable]
    public class ChatData
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }    //base64
        public string FileName { get; set; }
    }
}
