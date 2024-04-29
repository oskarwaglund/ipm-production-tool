using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipe = System.Collections.Generic.Dictionary<IpmProductionTool.Model.Resources.ResourceEnum, int>;
namespace IpmProductionTool.Model
{
	public class Calculator
	{

		double smeltReduction;
		double craftReduction;
		public Calculator(int underForgeLevel, int dormsLevel)
		{
			smeltReduction = underForgeLevel == 0 ? 1 : (0.9 - 0.04 * (underForgeLevel - 1));
			craftReduction = dormsLevel == 0 ? 1 : (0.9 - 0.04 * (dormsLevel - 1));
		}
		private Recipe Add(Recipe r1, Recipe r2)
		{
			var res = new Recipe();
			foreach(var r in r1)
			{
				res.Add(r.Key, r.Value);
			}
			foreach(var r in r2)
			{
				if (res.ContainsKey(r.Key))
				{
					res[r.Key] += r.Value;
				}
				else
				{
					res.Add(r.Key, r.Value);
				}
			}
			return res;
		}


		public ResourceEvaluation GetResourceEvaluation(Resources.ResourceEnum type)
		{
			var resource = Resources.GetResource(type);
			(var neededOre, int smeltTime, int craftTime) = GetNeededOre(type);
			var oreUsage = neededOre.Select(o => (o.Key, o.Value)).ToList();
			var oreValue = neededOre.Sum(o => Resources.GetResource(o.Key).Value * o.Value);
			return new ResourceEvaluation
			{
				Name = resource.Name,
				Value = resource.Value,
				OreUsage = oreUsage,
				OreValue = oreValue,
				SmeltTime = smeltTime,
				CraftTime = craftTime
			};
		}

		public (Recipe recipe, int smeltTime, int craftTime) GetNeededOre(Resources.ResourceEnum type)
		{
			var resource = Resources.GetResource(type);
			if (resource.Class == Resources.ClassEnum.ORE) throw new Exception("Trying to get ore needed for ore!");
			
			int smeltTime = resource.Class == Resources.ClassEnum.ALLOY ? resource.ProductionTime : 0;
			int craftTime = resource.Class == Resources.ClassEnum.ITEM ?  resource.ProductionTime : 0;
			
			var res = new Recipe();
			double multiplier = resource.Class == Resources.ClassEnum.ALLOY ? smeltReduction : craftReduction;
			foreach (var r in resource.Recipe)
			{
				var ress = Resources.GetResource(r.type);
				int quantity = ApplyMultiplier(r.quantity, multiplier);
				if(ress.Class == Resources.ClassEnum.ORE)
				{
					res = Add(res, new Recipe() { { r.type, quantity } }); 
				}
				else
				{
					(var sub, int subSmeltTime, int subCraftTime) = GetNeededOre(r.type);
					foreach(var v in sub.Keys)
					{
						sub[v] = sub[v] * quantity;
					}
					res = Add(res, sub);

					smeltTime += subSmeltTime * quantity;
					craftTime += subCraftTime * quantity;
				}
			}
			return (res, smeltTime, craftTime);
		}

		private int ApplyMultiplier(int quantity, double multiplier)
		{
			return Math.Max(1, (int)Math.Round(quantity * multiplier));//TODO
		}
	}
}
