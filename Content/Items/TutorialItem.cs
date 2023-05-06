﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace KypYoyo.Content.Items
{
    internal class TutorialItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            //this is how many of the thingy you need to smash to get it in journey mode :3
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults() 
        {
            Item.width = 16; //hitbox width + height, make sure is same as texture for simplicity ay?
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5); //value of the item
            Item.maxStack = 9999;
        }
    }
}
