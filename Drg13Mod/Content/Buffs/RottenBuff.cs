using Terraria;
using Terraria.ModLoader;
using Drg13Mod.Content.Items.Projectiles.Minion;

namespace Drg13Mod.Content.Buffs
{
    public class RottenBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rotting matter");
            Description.SetDefault("A rotting slime helps you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<RottenMob>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
