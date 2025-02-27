using ResoniteModLoader;
using FrooxEngine;


namespace AddAndModifyComponent
{
    public partial class AddAndModifyComponent : ResoniteMod
    {
        public override string Name => "AddAndModifyComponent";
        public override string Author => "CalamityLime";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/LimeProgramming/AddAndModifyComponent";

        public override void OnEngineInit()
        {
            Engine.Current.RunPostInit(() =>
            {
                Engine.Current.WorldManager.WorldAdded += AddComponent;
            });
        }
    }
}
