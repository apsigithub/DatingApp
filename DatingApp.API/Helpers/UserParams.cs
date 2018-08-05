namespace DatingApp.API.Helpers
{
    public class UserParams
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

        public string Gender { get; set; }

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 99;

        // For Sorting
        public string OrderBy { get; set; }
    }
}