
namespace bnApi.Settings;
public sealed class MongoDbConfig
{
    public string Name { get; init; }
    public string Host { get; init; }
    public int Port { get; init; }
    public string Username { get; init; }
    public string Password { get; init; }
    public string ConnectionString => $"mongodb+srv://{Username}:{Password}@{Host}/";
}