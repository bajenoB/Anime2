using System.Security.Cryptography;
using BCrypt;

namespace Anime.Data
{
    public static class Password
    {
        public static string MakeHash(string Pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(Pass, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public static bool IsUserPassValid(string Pass, string Passfromuser)
        {
            return BCrypt.Net.BCrypt.Verify(Pass, Passfromuser);
        }
    }
}
