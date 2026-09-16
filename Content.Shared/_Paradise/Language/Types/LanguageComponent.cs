using Robust.Shared.Prototypes;

namespace Content.Shared._Paradise.Language.Types;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent]
public sealed partial class LanguageComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadOnly)]
    public HashSet<ProtoId<LanguagePrototype>> Spoken = new();

    [DataField, ViewVariables(VVAccess.ReadOnly)]
    public HashSet<ProtoId<LanguagePrototype>> Understood = new();
}
