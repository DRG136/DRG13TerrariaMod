using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Drg13Mod.Content.Items.Projectiles.Weapons;

namespace Drg13Mod.Content.Items.Weapons.Melee
{
    internal class StonewoodSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stonewood Spear");
            Tooltip.SetDefault("One of the most primitive self-defense tools");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            //Hitbox of weapon
            Item.width = 32;
            Item.height = 32;

            //Animation and use of weapon
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useTime = 12;
            Item.useAnimation = 12;


            //Class and dmg of weapon
            Item.DamageType = DamageClass.Melee;
            Item.damage = 6;
            Item.knockBack = 6.5f;
            Item.crit = 4;

            //Misc
            Item.value = Item.buyPrice(copper: 88);
            Item.rare = ItemRarityID.White;

            //Sound
            Item.UseSound = SoundID.Item1;

            //Following cursor swing
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<StonewoodSpearProjectile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 5)
                .AddIngredient(ItemID.StoneBlock, 3)
                .AddTile(TileID.WorkBenches)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item

        }
    }
}
