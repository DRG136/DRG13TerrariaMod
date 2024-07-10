using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Accessories.Melee
{
    internal class MeleeProficiencyEmblem:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Melee Proficiency Emblem");
            Tooltip.SetDefault("Increases Melee penetration by 5 points\n"+
                "Master of the close quarters");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.accessory = true; //Sets this item as an accessory and can be equipped in accessory slots
            Item.defense = 7;  //Adds 7 defense to player when equipped
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Purple;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetArmorPenetration(DamageClass.Melee) += 0.5f; //Increases armor penetration by 5
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CopperShortsword, 1)
                .AddIngredient(ItemID.IronBar, 4)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            

        }
    }
}
