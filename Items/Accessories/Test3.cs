using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Runes.Items.Accessories
{
	public class Test3 : ModItem
	{
		public override void SetDefaults()
		{	
			Item.width = 26;
			Item.height = 30;
			Item.accessory = true;
			
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
            player.hasRaisableShield = true;
            player.dashType = 2;
        }


	}
		

	
}