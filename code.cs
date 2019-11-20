public class OTASecurity
    {
        public static string GenerateTokenString(string AppId, string AppKey)
        {
            var token = 1;
            return new { token = token, expires = int.MaxValue }.ObjectToJson();
        }

        
    }
