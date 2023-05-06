using KypYoyo.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace KypYoyo.Content.Tiles.Furniture
{
    public class YoyoSmithingStation : ModTile
    {

        //asdasdas
        public override string Texture => "KypYoyo/Assets/Tiles/Misc/YoyoSmithingStationTile";

        public override void SetStaticDefaults()
        {
            // Properties
            Main.tileTable[Type] = false;
            Main.tileSolidTop[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true; // This line makes NPCs not try to step up this tile during their movement. Only use this for furniture with solid tops.
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = false;
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.Height = 3;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Width = 4;


            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
            TileObjectData.newTile.Origin = new Point16(0, 0);
            //eepysdF
            TileObjectData.addTile(Type);

            LocalizedText YoyoSmithingStation = CreateMapEntryName();
            AddMapEntry(new Color(256,  256, 0), YoyoSmithingStation);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            base.KillMultiTile(i, j, frameX, frameY);
        }
    }

    public class YoyoSmithingStationItem : ModItem
    {
        public override string Texture => "KypYoyo/Assets/Items/Misc/YoyoSmithingStationItem";

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.YoyoSmithingStation>());
            Item.value = 150;
            Item.useStyle = ItemUseStyleID.Swing;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<TutorialItem>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }

}