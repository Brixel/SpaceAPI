using Newtonsoft.Json.Serialization;

namespace SpaceAPI.Controllers.Resolvers
{
    public class LowerCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string key)
        {
            return key.ToLower();
        }
    }
}