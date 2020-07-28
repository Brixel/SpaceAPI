using Newtonsoft.Json.Serialization;

namespace SpaceAPI.Host.Controllers.Resolvers
{
    public class LowerCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string key)
        {
            return key.ToLower();
        }
    }
}