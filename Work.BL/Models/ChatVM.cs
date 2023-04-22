﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.BL.Models
{
    public class ChatVM
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string RecieverName { get; set; }
        public string Message { get; set; }
        public string SenderId { get; set; }
        public string RecieverId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
