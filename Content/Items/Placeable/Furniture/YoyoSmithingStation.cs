/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KypYoyo.Content.Items.Placeable.Furniture;

namespace KypYoyo.Content.Items.Placeable.Furniture
{
    public class YoyoSmithingStation : ModItem
    {
        public override void SetDefaults()
        {
            
            // ModContent.TileType<Tiles.Furniture.ExampleWorkbench>() retrieves the id of the tile that this item should place when used.
            // DefaultToPlaceableTile handles setting various Item values that placeable items use
            // Hover over DefaultToPlaceableTile in Visual Studio to read the documentation!
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.YoyoSmithingStation>());
            Item.width = 32; // The item texture's width
            Item.height = 24; // The item texture's height
            Item.value = 150;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<TutorialItem>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
*/