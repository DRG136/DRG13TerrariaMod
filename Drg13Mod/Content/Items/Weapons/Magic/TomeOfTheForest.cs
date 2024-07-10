using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Drg13Mod.Content.Items.Projectiles.Weapons;

namespace Drg13Mod.Content.Items.Weapons.Magic
{
    internal class TomeOfTheForest:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tome Of The Forest");
            Tooltip.SetDefault("Nature's might in a 100% ecological weapon");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 30;
            //Animation
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.channel = true; //For holding the weapon
            //Sound
            Item.UseSound = SoundID.Item7;
            //Class and dmg
            Item.DamageType = DamageClass.Magic;
            Item.damage = 15;
            Item.knockBack = 3f;
            Item.noMelee = true;
            Item.mana = 5;
            //Misc
            Item.value = Item.buyPrice(silver: 50);
            Item.rare = ItemRarityID.Green;
            //Magic Projectile
            Item.shoot = ModContent.ProjectileType<LeafProjectile>();
            Item.shootSpeed = 20f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 40)
                .AddIngredient(ItemID.FallenStar,15)
                .AddTile(TileID.WorkBenches)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item

        }
    }
}
