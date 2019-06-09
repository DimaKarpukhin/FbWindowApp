namespace AppLogic
{
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;
    
    public class TaggedFriend
    {
        public User User { get; set; }

        public int Likes { get; set; } = 0;

        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}
