using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
    
namespace bnApi.Models;

[CollectionName("Roles")]
public class ApplicationRole : MongoIdentityRole<Guid>
{

}