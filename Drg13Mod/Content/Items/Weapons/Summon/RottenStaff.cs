using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Drg13Mod.Content.Buffs;
using Drg13Mod.Content.Items.Projectiles.Minion;

namespace Drg13Mod.Content.Items.Weapons.Summon
{
    public class RottenStaff:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rotten Staff");
            Tooltip.SetDefault("Summons slime of rotten matter to fight for you\n"+
                "Power rots people");
            ItemID.Sets.LockOnIgnoresCollision[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            //stats
            Item.damage = 18;
            Item.knockBack = 1f;
            Item.mana = 10;
            //animation
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = ItemUseStyleID.Swing;
            //misc
            Item.value = Item.sellPrice(silver:50);
            Item.rare = ItemRarityID.White;
            //sound
            Item.UseSound = SoundID.Item44;
            //kind of dmg and projectile+buff
            Item.noMelee = true;
            Item.DamageType = DamageClass.Summon;
            Item.buffType = ModContent.BuffType<RottenBuff>();
            Item.shoot = ModContent.ProjectileType<RottenMob>();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            position = Main.MouseWorld;//summons on the cursor
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.AddBuff(Item.buffType, 2);//adds the buff for the minion

            var projectile = Projectile.NewProjectileDirect(source, position, velocity, type, damage, knockback, Main.myPlayer);
            projectile.originalDamage = Item.damage;

            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.RottenChunk, 10)
                .AddIngredient(ItemID.IronBar, 2)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            CreateRecipe()
                .AddIngredient(ItemID.Vertebrae, 10)
                .AddIngredient(ItemID.IronBar, 2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
