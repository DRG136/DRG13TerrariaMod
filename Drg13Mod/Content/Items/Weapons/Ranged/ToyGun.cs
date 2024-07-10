using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Drg13Mod.Content.Items.Weapons.Ranged
{
    internal class ToyGun:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toy Gun");
            Tooltip.SetDefault("Don't toy with me");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type]= 1;
        }
        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 30;

            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.value = Item.buyPrice(silver: 15);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item96;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 15;
            Item.knockBack = 2f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 6f;

            Item.useAmmo = AmmoID.Bullet;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-4f, 2f);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Gel, 40)
                .AddIngredient(ItemID.IronBar, 8)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
        }
    }
}
