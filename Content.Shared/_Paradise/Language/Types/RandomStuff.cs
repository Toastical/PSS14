using Robust.Shared.Prototypes;

namespace Content.Shared._Paradise.Language.Types;

public readonly record struct LanguageSegment(
    ProtoId<LanguagePrototype> LanguageId,
    Color Color,
    string Original,
    string Garbled
);
