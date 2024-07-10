using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Accessories.Ranged
{
    internal class RangedProficiencyEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ranged Proficiency Emblem");
            
            Tooltip.SetDefault("Increases Ranged damage by 10%\n" +
                "Increases Ranged penetration by 8 points\n" +
                "Increases Ranged Crit Chance by 10%\n" +
                "A true sharpshooter");
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
            player.GetArmorPenetration(DamageClass.Ranged) += 0.8f; //Increases ranged weapons armor penetration by 8
            player.GetDamage(DamageClass.Ranged) += 0.1f; //Increases damage for ranged class by 10%
            player.GetCritChance(DamageClass.Ranged) += 10f; //Increases the crit chance
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 100)
                .AddIngredient(ItemID.IronBar, 2)
                .AddIngredient(ItemID.Gel,10)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
        }
    }
}
