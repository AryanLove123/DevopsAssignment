﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentAdded { get; set; }
        public DateTime Date { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
