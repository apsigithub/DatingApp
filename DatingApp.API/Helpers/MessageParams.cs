namespace DatingApp.API.Helpers
{
    public class MessageParams
    {
                // The following properties are for PAGING
        private const int MaxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
        // The following properties are for FILTERING
        public int UserId { get; set; }

        public string MessageContainer { get; set; } = "Unread";
    }
}