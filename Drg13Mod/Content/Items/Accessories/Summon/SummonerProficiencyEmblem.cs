using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Accessories.Summon
{
    internal class SummonerProficiencyEmblem:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoner Proficiency Emblem");
            Tooltip.SetDefault("Increases Summon damage by 30%\n" +
                "Increases maximum Minion Slots by 2\n" +
                "A masterful tamer");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.accessory = true; //Sets this item as an accessory and can be equipped in accessory slots
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Purple;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Summon) += 0.3f; //Increases summon damage by 20%
            player.maxMinions += 2; //Increases minion slots by 2

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.RottenChunk, 2)
                .AddIngredient(ItemID.IronBar, 5)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            CreateRecipe()
                .AddIngredient(ItemID.Vertebrae, 2)
                .AddIngredient(ItemID.IronBar, 5)
                .AddTile(TileID.Anvils)
                .Register();


        }
    }
}
