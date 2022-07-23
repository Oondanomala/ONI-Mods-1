﻿using STRINGS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNING;
using UnityEngine;

namespace FreeResourceBuildings
{
	public class FoodStorageGenerator : FreeStorage
	{
		protected override void OnSpawn()
		{
			base.OnSpawn();


			var allFood = EdiblesManager.GetAllFoodTypes();

			foreach (EdiblesManager.FoodInfo food in allFood)
			{

				if ((double)food.CaloriesPerUnit == 0.0)
					DiscoveredResources.Instance.Discover(food.Id.ToTag(), GameTags.CookingIngredient);
				else
					DiscoveredResources.Instance.Discover(food.Id.ToTag(), GameTags.Edible);
			}
		}

	}
}
 
