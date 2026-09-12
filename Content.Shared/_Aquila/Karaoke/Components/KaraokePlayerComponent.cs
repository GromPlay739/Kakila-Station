using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Content.Shared.Containers.ItemSlots;
using Robust.Shared.Containers;

namespace Content.Shared.Aquila.Karaoke.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
//[, RegisterComponent, AutoGenerateComponentState(true)]
public sealed partial class AquilaKaraokePlayerComponent : Component
{
    [DataField("tapeComtainer", required: true), AutoNetworkedField]
    public ItemSlot TapeContainer = new();

    [DataField, AutoNetworkedField]
    public bool IsPlaying = false;

    [DataField, AutoNetworkedField]
    public bool IsFemale = false;

    [DataField, AutoNetworkedField]
    public float Offset = 0f;

    [DataField, AutoNetworkedField]
    public EntityUid? MainAudioStream;
}