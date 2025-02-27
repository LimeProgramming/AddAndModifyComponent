using FrooxEngine;
using ResoniteModLoader;

namespace AddAndModifyComponent;

public partial class AddAndModifyComponent : ResoniteMod
{
    private static void AddComponent(World world)
    {
        world.RunSynchronously(() =>
        {
            Slot DemoSlot = world.AddSlot(world.RootSlot, "DemoSlotMod", false);
            var Comment = DemoSlot.AttachComponent<Comment>();
            Comment.Text.Value = "That was easy!";
        });
    }
}