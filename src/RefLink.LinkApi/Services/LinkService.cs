namespace LinkApi.Services;

public interface ILinkService
{
    Task<List<LinkItem>> GetAll();
}

public class LinkService: ILinkService
{
    private readonly List<LinkItem> linkItems = new List<LinkItem>
    {
        new LinkItem(1, "url1", "desc1"),
        new LinkItem(2, "url2", "desc2"),
        new LinkItem(3, "url3", "desc3"),
    };
        
    public Task<List<LinkItem>> GetAll() => Task.FromResult(linkItems);
}

public class LinkItem
{
    public LinkItem(long itemId, string itemUrl, string itemDescription)
    {
        ItemId = itemId;
        ItemUrl = itemUrl;
        ItemDescription = itemDescription;
    }
    
    public long ItemId { get; }
    public string ItemUrl { get; }
    public string ItemDescription { get; } 
    
}
