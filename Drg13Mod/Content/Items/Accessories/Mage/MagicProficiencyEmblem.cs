using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Accessories.Mage
{
    internal class MagicProficiencyEmblem:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Proficiency Emblem");
            Tooltip.SetDefault("Increases Magic damage by 20%\n" +
                "Increases maximum Mana by 20\n"+
                "Increases Magic penetration by 7 points\n" +
                "A true mage masters all magic");
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
            player.GetDamage(DamageClass.Magic)+=0.2f; //Increases magic damage by 20%
            player.GetArmorPenetration(DamageClass.Magic) += 0.7f;//Increases magic pen by 7
            player.statManaMax2 += 20; //Increases mana by 20

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FallenStar, 10)
                .AddIngredient(ItemID.Wood, 5)
                .AddIngredient(ItemID.IronBar,2)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
        }
    }
}
