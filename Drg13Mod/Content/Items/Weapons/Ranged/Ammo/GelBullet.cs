using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Drg13Mod.Content.Items.Projectiles.Weapons;

namespace Drg13Mod.Content.Items.Weapons.Ranged.Ammo
{
    internal class GelBullet:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel Bullet");
            Tooltip.SetDefault("It bounces");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height=8;

            Item.damage = 6;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 4f;

            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(copper:3);
            Item.rare = ItemRarityID.White;

            Item.ammo = AmmoID.Bullet; //Marks its ammo type to a bullet
            Item.shoot = ModContent.ProjectileType<GelAmmoProjectile>();
        }
        public override void AddRecipes()
        {
            CreateRecipe(100)
                .AddIngredient(ItemID.Gel, 5)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
        }
    }
}
