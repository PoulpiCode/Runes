using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Runes.Items.Weapons
{
	public class BigMace : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Runes.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 150;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 100;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.scale = 4f;
			Item.rare = ItemRarityID.Cyan;
		}
		
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
            // Inflict the OnFire debuff for 1 second onto any NPC/Monster that this hits.
            // 60 frames = 1 second
            target.AddBuff(BuffID.Weak, 240);
            target.AddBuff(BuffID.BrokenArmor, 240);
            target.AddBuff(BuffID.Slow, 240);

        }
	}
}