using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserForgotPasswordRequest
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public DateTime ExpireTime { get; set; }
    }
}
