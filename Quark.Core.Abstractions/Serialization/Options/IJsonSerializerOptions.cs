using System.Text.Json;

namespace Quark.Core.Abstractions.Serialization.Options;

public interface IJsonSerializerOptions
{
    /// <summary>
    /// Options for <see cref="System.Text.Json"/>.
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; }
}