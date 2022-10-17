namespace MagicVilla_Utility
{
    public class SD
    {
        public enum APIType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static string SessionToken = "JWTToken";

        // caching profiles
        public const string Default30Sec = "Default30";
        public const string Default60Sec = "Default60";
        public const string DefaultNoStore = "DefaultNoStore";
    }
}