namespace LinkedIn.Essentials
{
    static class Constants {
        private static string connectionString;
        public static readonly string SERVER_NAME = "any-key";
        public const string DATABASE_NAME = "some-db";

        public static DateTime GetDate(DateOnly dt) {
            return new DateTime(dt.Year, dt.Month, dt.Day);
        }
        static Constants() {
            connectionString = "Server...";
        }
    }
}
