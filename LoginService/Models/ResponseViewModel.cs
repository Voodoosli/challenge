using System;

namespace LoginService.Models
{
    public class ResponseViewModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public TokenInfo TokenInfo { get; set; }
    }

    public class TokenInfo
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }


}
