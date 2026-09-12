using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Audio;

namespace Content.Shared.Aquila.Karaoke.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
//[NetworkedComponent, RegisterComponent, AutoGenerateComponentState(true)]
public sealed partial class AquilaKaraokeTapeComponent : Component
{
    [DataField(required: true), AutoNetworkedField]
    public SoundPathSpecifier BackSound = default!;

    [DataField(required: true), AutoNetworkedField]
    public SoundPathSpecifier MaleVoice = default!;

    [DataField(required: true), AutoNetworkedField]
    public SoundPathSpecifier FemaleVoice = default!;
}