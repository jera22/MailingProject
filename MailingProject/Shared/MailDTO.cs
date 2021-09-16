﻿using System;

namespace Shared
{
    public class MailDTO
    {
        public Guid Id {  get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public ImportanceEnum Importance { get; set; }
    }

    public enum ImportanceEnum
    {
        Low,
        Medium,
        Important
    }
}
