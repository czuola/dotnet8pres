using System.Text.Json.Serialization.Metadata;
using System.Text.Json;

var options = new JsonSerializerOptions
{
    TypeInfoResolver = JsonTypeInfoResolver.Combine(
        ContextA.Default, ContextB.Default, ContextC.Default);
};

options.TypeInfoResolverChain.Count; // 3
options.TypeInfoResolverChain.RemoveAt(0);
options.TypeInfoResolverChain.Count; // 2