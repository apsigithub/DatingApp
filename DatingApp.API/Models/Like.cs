namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; }  // this represents a user who likes another user

        public int LikeeId { get; set; } // this reprents the user been liked by another user

        public User Liker { get; set; }

        public User Likee { get; set; }
    }
}