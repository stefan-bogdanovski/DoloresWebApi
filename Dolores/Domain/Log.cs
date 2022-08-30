﻿namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Log
	{
        public int Id { get; set; }
        public string UseCaseName { get; set; }
        public int? UserId { get; set; }
        public DateTime ExecutionDateTime { get; set; }
        public string Data { get; set; }
        public bool IsAuthorized { get; set; }

        public virtual User User { get; set; }
    }
}
