using System.Text.Json;
using Quark.Core.Abstractions.Serialization.Options;

namespace Quark.Core.Serialization.Options;

public class SystemTextJsonOptions : IJsonSerializerOptions
{
    public JsonSerializerOptions JsonSerializerOptions { get; } = new();
}