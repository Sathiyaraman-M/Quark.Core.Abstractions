using Newtonsoft.Json;
using Quark.Core.Abstractions.Serialization.Settings;

namespace Quark.Core.Serialization.Settings;

public class NewtonsoftJsonSettings : IJsonSerializerSettings
{
    public JsonSerializerSettings JsonSerializerSettings { get; } = new();
}