﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Domain.Domain
{
    public class EmailMessage : BaseEntity
    {
        public string emailsendTo { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Boolean Status { get; set; }
    }
}
