using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Armors.Melee
{
    [AutoloadEquip(EquipType.Body)]
    internal class AlloyBreastplate:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Alloy Breastplate");
        }
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 30);
            Item.rare = ItemRarityID.Blue;

            Item.defense = 7;

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.SilverBar, 15)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.TungstenBar, 15)
                .AddTile(TileID.Anvils)
                .Register();

        }
    }
}
