using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Drg13Mod.Content.Items.Projectiles.Weapons
{
    internal class LeafProjectile:ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.Leaf);
            AIType = ProjectileID.Leaf; //Same Ai and behaviour as the projectile of an existing item when shot
        }
        public override bool PreKill(int timeLeft)
        {
            Projectile.type = ProjectileID.Leaf;
            return true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Poisoned, 300); //On hit 50% to poison for 5 secs
            }
        }
    }
}
