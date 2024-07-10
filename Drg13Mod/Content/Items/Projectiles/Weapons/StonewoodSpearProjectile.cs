using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace Drg13Mod.Content.Items.Projectiles.Weapons
{
    internal class StonewoodSpearProjectile:ModProjectile
    {
        public override void SetDefaults()
        {
            //Hitbox of projectile
            Projectile.width = 24;
            Projectile.height = 24;

            //Shot by player
            Projectile.friendly= true;
            Projectile.penetrate = -1; //Doesn't break no matter how many entities it penetrates
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;//Doesn't hit through walls
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 300;

            Projectile.aiStyle = ProjAIStyleID.ShortSword;
        }
        public override void AI()
        {
            base.AI();
            Projectile.rotation=Projectile.velocity.ToRotation()+MathHelper.PiOver2-MathHelper.PiOver4*Projectile.spriteDirection;
            int halfProjWidth=Projectile.width/2;
            int halfProjHeight=Projectile.height/2;
            DrawOriginOffsetX = 0;
            DrawOffsetX = -((32 / 2) - halfProjWidth);
            DrawOriginOffsetY= -((32 / 2) - halfProjHeight);
        }
    }
}
