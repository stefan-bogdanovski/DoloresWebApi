namespace Dolores.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class JwtSettings
    {
        public int Minutes { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
    }
}
