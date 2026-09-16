using Robust.Shared.Prototypes;

namespace Content.Shared._Paradise.Language.Types;

/// <summary>
/// This is a prototype for...
/// </summary>
[Prototype("language")]
public sealed partial class LanguagePrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true), ViewVariables]
    public string Name { get; set; } = "Unknown language";

    [DataField(required: true), ViewVariables]
    public Color Color { get; set; } = Color.Lime;

    [DataField(required: true), ViewVariables]
    public List<string> Syllables { get; set; } = new() {"guh", "blah", "buh"};
}
