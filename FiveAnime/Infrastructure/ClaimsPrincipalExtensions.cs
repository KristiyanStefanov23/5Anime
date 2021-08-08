using System;
using System.Security.Claims;

namespace FiveAnime.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal principal)
            => principal.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static bool IsAdmin(this ClaimsPrincipal principal)
            => principal.IsInRole("Admin");

        public static int CurrentYear()
        {
            return DateTime.UtcNow.Year;
        }
    }
}
