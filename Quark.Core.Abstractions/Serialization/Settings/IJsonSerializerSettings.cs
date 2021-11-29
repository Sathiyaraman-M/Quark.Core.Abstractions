using Newtonsoft.Json;

namespace Quark.Core.Abstractions.Serialization.Settings;

public interface IJsonSerializerSettings
{
    /// <summary>
    /// Settings for <see cref="Newtonsoft.Json"/>.
    /// </summary>
    public JsonSerializerSettings JsonSerializerSettings { get; }
}