using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Runes.Items.Weapons
{
	public class Test2 : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Runes.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 100;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}


		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}






	}
}