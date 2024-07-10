using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Armors.Ranged
{
    [AutoloadEquip(EquipType.Head)]
    internal class GelHelmet:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Gel Helmet");
        }
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            Item.defense = 4;

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<GelBreastplate>();
            bool legsMatch = legs.type == ModContent.ItemType<GelBoots>();
            return bodyMatch && legsMatch;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases Ranged damage by 20%\n" + "Increases Ranged Crit Chance by 15%";
            player.GetDamage(DamageClass.Ranged) += 0.2f;
            player.GetCritChance(DamageClass.Ranged) += 15f;
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
