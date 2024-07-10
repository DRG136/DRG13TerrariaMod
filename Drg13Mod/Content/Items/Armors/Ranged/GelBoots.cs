using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Armors.Ranged
{
    [AutoloadEquip(EquipType.Legs)]
    internal class GelBoots:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Gel Boots");
        }
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 30);
            Item.rare = ItemRarityID.Blue;

            Item.defense = 4;

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Gel, 20)
                .AddIngredient(ItemID.IronBar, 5)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
        }
    }
}
