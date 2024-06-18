namespace bnApi.Models;
public sealed class Moment()
{
    public Guid Id;
    public string Title;
    public string Description;
    public string Quote;
    public List<string> ImageUrls;
    public DateTime DateCreated;
    public DateTime LastUpdated;
    public string CreatedBy;
    public List<string> TaggedUsers;

}