using Dalamud.Game.ClientState.Objects.SubKinds;
using TrackyTrack.Data;

namespace TrackyTrack;

[Serializable]
//From: https://github.com/MidoriKami/DailyDuty/
public class CharacterConfiguration
{
    // Increase with version bump
    public int Version { get; set; } = 1;

    public ulong LocalContentId;

    public string CharacterName = "";
    public string World = "Unknown";

    public uint Teleports = 0;
    public uint TeleportsWithTicket = 0;
    public uint TeleportCost = 0;

    public uint Repairs = 0;
    public uint RepairCost = 0;

    public Desynth Storage = new();
    public VentureCoffer Coffer = new();
    public GachaThreeZero GachaThreeZero = new();
    public GachaFourZero GachaFourZero = new();

    public CharacterConfiguration() { }

    public CharacterConfiguration(ulong id, PlayerCharacter local)
    {
        LocalContentId = id;
        CharacterName = Utils.ToStr(local.Name);
        World = Utils.ToStr(local.HomeWorld.GameData!.Name);
    }

    public static CharacterConfiguration CreateNew() => new()
    {
        LocalContentId = Plugin.ClientState.LocalContentId,

        CharacterName = Plugin.ClientState.LocalPlayer?.Name.ToString() ?? "",
        World = Plugin.ClientState.LocalPlayer?.HomeWorld.GameData?.Name.ToString() ?? "Unknown"
    };
}
