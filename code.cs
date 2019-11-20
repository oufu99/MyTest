public class OTASecurity
    {
        public static string GenerateTokenString(string AppId, string AppKey)
        {
            var token = GenerateToken(AppId, AppKey);
            return new { token = token, expires = int.MaxValue }.ObjectToJson();
        }

        
    }
