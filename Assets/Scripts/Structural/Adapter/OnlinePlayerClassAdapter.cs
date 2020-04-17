namespace Structural.Adapter
{
    public class OnlinePlayerClassAdapter: OnlinePlayer, IOnlinePlayer
    {
        public string GetFullNameLastFirst(int userId)
        {
            return GetFullName(userId);
        }

        public string GetFullNameFirstLast(int userId)
        {
            return GetFirstName(userId) + " " + GetLastName(userId);
        }
    }
}