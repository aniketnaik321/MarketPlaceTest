namespace MarketPlace.Web.DTO
{
    public class DtoProducts
    {

            public int Id { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public string ThumbnailImageUrl { get; set; }
            public string RedirectUrl { get; set; }
        
    }
}
