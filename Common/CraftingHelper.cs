using System.Collections.Generic;
/* Unmerged change from project 'Hydrology'
Before:
using System.Text;

using StardewValley;

using Leclair.Stardew.Common.Crafting;
After:
using System.Text;

using Leclair.Stardew.Common.Crafting;
*/

/* Unmerged change from project 'Almanac'
Before:
using System.Text;

using StardewValley;

using Leclair.Stardew.Common.Crafting;
After:
using System.Text;

using Leclair.Stardew.Common.Crafting;
*/

/* Unmerged change from project 'SeeMeRollin'
Before:
using System.Text;

using StardewValley;

using Leclair.Stardew.Common.Crafting;
After:
using System.Text;

using Leclair.Stardew.Common.Crafting;
*/


using Leclair.Stardew.Common.Crafting;
using Leclair.Stardew.Common.Inventory;

using StardewValley;

namespace Leclair.Stardew.Common {
	public static class CraftingHelper {

		public static bool HasIngredients(IIngredient[] ingredients, Farmer who, IList<Item> items, IList<WorkingInventory> inventories) {
			foreach (var entry in ingredients)
				if (entry.GetAvailableQuantity(who, items, inventories) < entry.Quantity)
					return false;

			return true;
		}

		public static bool HasIngredients(this IRecipe recipe, Farmer who, IList<Item> items, IList<WorkingInventory> inventories) {
			return HasIngredients(recipe.Ingredients, who, items, inventories);
		}

		public static void ConsumeIngredients(IIngredient[] ingredients, Farmer who, IList<WorkingInventory> inventories) {
			foreach (var entry in ingredients)
				entry.Consume(who, inventories);
		}

		public static void Consume(this IRecipe recipe, Farmer who, IList<WorkingInventory> inventories) {
			ConsumeIngredients(recipe.Ingredients, who, inventories);
		}

	}
}