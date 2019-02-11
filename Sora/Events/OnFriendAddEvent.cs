using EventManager.Attributes;
using Shared.Models;
using Shared.Services;
using Sora.EventArgs;

namespace Sora.Events
{
    [EventClass]
    public class OnFriendAddEvent
    {
        private readonly Database _db;

        public OnFriendAddEvent(Database db)
        {
            _db = db;
        }
        
        public void OnFriendAdd(BanchoFriendAddArgs args)
        {
            Friends.AddFriend(_db, args.pr.User.Id, args.FriendId);
        }
    }
}