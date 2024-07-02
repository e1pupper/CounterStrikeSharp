
namespace CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;

public partial class CUsercmd : NativeObject
{
    /*
    Reference:
    https://github.com/alliedmodders/hl2sdk/blob/4c27c1305c5e042ae1f62f6dc6ba7e96fd06e05d/game/shared/usercmd.h#L30
    */

    public CUsercmd(IntPtr pointer) : base(pointer) { }

    [SchemaMember("CUsercmd", "command_number")]
    public ref int CommandNumber => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "command_number");

    [SchemaMember("CUsercmd", "tick_count")]
    public ref int TickCount => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "tick_count");

    // someone please do QAngle thanks
    //[SchemaMember("CUsercmd", "viewangles")]
    //public ref QAngle ViewAngles => ref Schema.GetRef<QAngle>(this.Handle, "CUsercmd", "viewangles");

    [SchemaMember("CUsercmd", "forwardmove")]
    public ref float ForwardMove => ref Schema.GetRef<float>(this.Handle, "CUsercmd", "forwardmove");

    [SchemaMember("CUsercmd", "sidemove")]
    public ref float SideMove => ref Schema.GetRef<float>(this.Handle, "CUsercmd", "sidemove");

    [SchemaMember("CUsercmd", "upmove")]
    public ref float UpMove => ref Schema.GetRef<float>(this.Handle, "CUsercmd", "upmove");

    [SchemaMember("CUsercmd", "buttons")]
    public ref int Buttons => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "buttons");

    [SchemaMember("CUsercmd", "impulse")]
    public ref byte Impulse => ref Schema.GetRef<byte>(this.Handle, "CUsercmd", "impulse");

    [SchemaMember("CUsercmd", "weaponselect")]
    public ref int WeaponSelect => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "weaponselect");

    [SchemaMember("CUsercmd", "weaponsubtype")]
    public ref int WeaponSubtype => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "weaponsubtype");

    [SchemaMember("CUsercmd", "random_seed")]
    public ref int RandomSeed => ref Schema.GetRef<int>(this.Handle, "CUsercmd", "random_seed");

    [SchemaMember("CUsercmd", "mousedx")]
    public ref short MouseDx => ref Schema.GetRef<short>(this.Handle, "CUsercmd", "mousedx");

    [SchemaMember("CUsercmd", "mousedy")]
    public ref short MouseDy => ref Schema.GetRef<short>(this.Handle, "CUsercmd", "mousedy");

    [SchemaMember("CUsercmd", "hasbeenpredicted")]
    public ref bool HasBeenPredicted => ref Schema.GetRef<bool>(this.Handle, "CUsercmd", "hasbeenpredicted");
}