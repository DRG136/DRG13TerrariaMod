using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Weapons.Melee
{
    internal class AlloyLongSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alloy LongSword");
            Tooltip.SetDefault("A sword made from a combination of metals");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            //Hitbox of weapon
            Item.width = 32;
            Item.height = 32;

            //Animation and use of weapon
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            //Class and dmg of weapon
            Item.DamageType = DamageClass.Melee;
            Item.damage = 18;
            Item.knockBack = 5.5f;
            Item.crit = 10;

            //Misc
            Item.value = Item.buyPrice(silver: 10, copper: 57);
            Item.rare = ItemRarityID.White;

            //Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 6)
                .AddIngredient(ItemID.SilverBar, 4)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 6)
                .AddIngredient(ItemID.TungstenBar, 4)
                .AddTile(TileID.Anvils)
                .Register();

        }
    }
}
