using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Items.Armors.Melee
{
    [AutoloadEquip(EquipType.Head)]
    internal class AlloyHelmet:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Alloy Helmet");
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
            bool bodyMatch = body.type == ModContent.ItemType<AlloyBreastplate>();
            bool legsMatch=legs.type==ModContent.ItemType<AlloyBoots>();
            return bodyMatch && legsMatch;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases Melee damage by 5%\n"+"Slightly increases movement speed";
            player.GetDamage(DamageClass.Melee) += 0.05f;
            player.moveSpeed += 0.07f; //Slightly increases speed (must be low number)
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.SilverBar, 10)
                .AddTile(TileID.Anvils)
                .Register();  //Adds the ingredients to the recipe, the place to craft and the registers the item
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.TungstenBar, 10)
                .AddTile(TileID.Anvils)
                .Register();

        }
    }
}
