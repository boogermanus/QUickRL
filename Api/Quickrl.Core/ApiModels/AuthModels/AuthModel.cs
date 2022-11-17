namespace Quickrl.Core.ApiModels.AuthModels
{
    public class AuthModel
    {
        // needed for deserialization
        public AuthModel() {}
        
        public AuthModel(string token, string userId)
        {
            Token = token;
            UserId = userId;
        }
        
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}