using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Quark.Core.Serialization.Settings;
using Quark.Core.Abstractions.Serialization.Serializers;

namespace Quark.Core.Serialization.Serializers;

public class NewtonSoftJsonSerializer : IJsonSerializer
{
    private readonly JsonSerializerSettings _settings;

    public NewtonSoftJsonSerializer(IOptions<NewtonsoftJsonSettings> settings)
    {
        _settings = settings.Value.JsonSerializerSettings;
    }

    public T Deserialize<T>(string text)
        => JsonConvert.DeserializeObject<T>(text, _settings);

    public string Serialize<T>(T obj)
        => JsonConvert.SerializeObject(obj, _settings);
}