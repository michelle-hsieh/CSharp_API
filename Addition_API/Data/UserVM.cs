using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addition_API.Data
{
    public class UserVM
    {
        public string UserId { get; set; } = "";
        public string PW { get; set; } = "";
        public string UserName { get; set; } = "";
        public string EMail { get; set; } = "";
        public string UserToken { get; set; } = "";

    }
}