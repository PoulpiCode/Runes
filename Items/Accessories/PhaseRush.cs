using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

/*test*/
namespace Runes.Items.Accessories
{   

	public class PhaseRush : ModItem
	{                       

		public override void SetDefaults()
		{	

            Item.rare = ItemRarityID.Blue;
			Item.width = 26;
			Item.height = 30;
			Item.accessory = true;
            Item.knockBack = 15;
			
		}
		
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {   
            var line = new TooltipLine(Mod, "Verbose:RemoveMe", "This tooltip won't show in-game");
            tooltips.Add(line);

            line = new TooltipLine(Mod, "Face","Je cour vite"){
                OverrideColor = new Color(100, 100, 255)
            };
            tooltips.Add(line);

            line = new TooltipLine(Mod,"","+200% movespeed"){
                OverrideColor = new Color(163,67,67)
            };
            tooltips.Add(line);
        }


        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

		 public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 2f;
            /*player.AddBuff(BuffID.OnFire, 120);*/
        }


        
             
    }
}