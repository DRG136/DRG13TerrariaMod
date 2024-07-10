using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Drg13Mod.Content.Recipes
{
    public class CustomRecipes:ModSystem
    {
        public override void AddRecipes()
        {
            Recipe leatherWhipRecipe = Recipe.Create(ItemID.BlandWhip);
            leatherWhipRecipe.AddIngredient(ItemID.Wood, 50);
            leatherWhipRecipe.AddIngredient(ItemID.Acorn, 10);
            leatherWhipRecipe.AddTile(TileID.Anvils);
            leatherWhipRecipe.Register();
        }
    }
}
