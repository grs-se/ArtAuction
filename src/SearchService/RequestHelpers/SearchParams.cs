namespace SearchService.RequestHelpers
{
    public class SearchParams
    {
        // Can go as far as I want with this, adding as many search params as I like
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public string Seller { get; set; }
        public string Winner { get; set; }
        public string OrberBy { get; set; }
        public string FilterBy { get; set; }
    }
}
