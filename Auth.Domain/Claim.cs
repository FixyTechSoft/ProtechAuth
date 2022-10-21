using System;

namespace Auth.Domain
{
    public class Claim
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
