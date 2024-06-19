using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace bnApi.Models;

[CollectionName("Users")]
public class ApplicationUser : MongoIdentityUser<Guid>
{
    
}