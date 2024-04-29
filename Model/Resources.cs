using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IpmProductionTool.Model
{
	public class Resources
	{
		public enum ResourceEnum
		{
			//Resources
			COPPER,
			IRON,
			LEAD,
			SILICA,
			ALUMINUM,
			SILVER,
			GOLD,
			DIAMOND,
			PLATINUM,
			TITANIUM,
			IRIDIUM,
			PALLADIUM,
			OSMIUM,
			RHODIUM,

			//Resources
			COPPER_BAR,
			IRON_BAR,
			LEAD_BAR,
			SILICON_BAR,
			ALUMINUM_BAR,
			SILVER_BAR,
			GOLD_BAR,
			BRONZE_BAR,
			STEEL_BAR,
			PLATINUM_BAR,
			TITANIUM_BAR,
			IRIDIUM_BAR,
			PALLADIUM_BAR,
			OSMIUM_BAR,
			RHODIUM_BAR,


			//Items
			COPPER_WIRE,
			IRON_NAIL,
			BATTERY,
			HAMMER,
		}

		public enum ClassEnum
		{
			ORE,
			ALLOY,
			ITEM
		}

		public class Resource
		{
			public Resource(ClassEnum clazz, ResourceEnum type, double value, int productionTime = 0, List<(ResourceEnum type, int quantity)> recipe = null)
			{
				Class = clazz;
				Type = type;
				Value = value;
				ProductionTime = productionTime;
				Recipe = recipe; 
			}
			public ClassEnum Class { get; private set; } 
			public ResourceEnum Type { get; private set; }
			public double Value { get; private set; } //$
			public int ProductionTime { get; private set; } //seconds

			public readonly List<(ResourceEnum type, int quantity)> Recipe;
			public string Name => NameOf(Type);
		}

		public static string NameOf(ResourceEnum e)
		{
			return Enum.GetName(typeof(ResourceEnum), e);
		}

		public static Resource GetResource(ResourceEnum e)
		{
			if (ResourceLookup == null)
			{
				InitResources();
			}
			return ResourceLookup[e];
		}

		private static void InitResources()
		{
			ResourceLookup = new();
			
			//Ore
			NewOre(ResourceEnum.COPPER, 1);
			NewOre(ResourceEnum.IRON, 2);
			NewOre(ResourceEnum.LEAD, 4);
			NewOre(ResourceEnum.SILICA, 8);
			NewOre(ResourceEnum.ALUMINUM, 17);
			NewOre(ResourceEnum.SILVER, 36);
			NewOre(ResourceEnum.GOLD, 75);
			NewOre(ResourceEnum.DIAMOND, 160);
			NewOre(ResourceEnum.PLATINUM, 340);
			NewOre(ResourceEnum.TITANIUM, 730);
			NewOre(ResourceEnum.IRIDIUM, 1600);
			NewOre(ResourceEnum.PALLADIUM, 3500);
			NewOre(ResourceEnum.OSMIUM, 7800);
			NewOre(ResourceEnum.RHODIUM, 17500);

			//Alloy
			NewAlloy(ResourceEnum.COPPER_BAR, 20, 1450, new() { (ResourceEnum.COPPER, 1000) });
			NewAlloy(ResourceEnum.IRON_BAR, 30, 3000, new() { (ResourceEnum.IRON, 1000) });
			NewAlloy(ResourceEnum.LEAD_BAR, 40, 6100, new() { (ResourceEnum.LEAD, 1000) });
			NewAlloy(ResourceEnum.SILICON_BAR, 60, 12500, new() { (ResourceEnum.SILICA, 1000) });
			NewAlloy(ResourceEnum.ALUMINUM_BAR, 80, 27600, new() { (ResourceEnum.ALUMINUM, 1000) });
			NewAlloy(ResourceEnum.SILVER_BAR, 120, 60000, new() { (ResourceEnum.SILVER, 1000) });
			NewAlloy(ResourceEnum.GOLD_BAR, 180, 120000, new() { (ResourceEnum.GOLD, 1000) });
			NewAlloy(ResourceEnum.BRONZE_BAR, 240, 234000, new() { (ResourceEnum.SILVER_BAR, 2), (ResourceEnum.COPPER_BAR, 10) });
			NewAlloy(ResourceEnum.STEEL_BAR, 480, 340000, new() { (ResourceEnum.LEAD_BAR, 15), (ResourceEnum.IRON_BAR, 30) });
			NewAlloy(ResourceEnum.PLATINUM_BAR, 600, 780000, new() { (ResourceEnum.GOLD_BAR, 2), (ResourceEnum.PLATINUM, 1000) });
			NewAlloy(ResourceEnum.TITANIUM_BAR, 720, 1630000, new() { (ResourceEnum.BRONZE_BAR, 2), (ResourceEnum.TITANIUM, 1000) });
			NewAlloy(ResourceEnum.IRIDIUM_BAR, 840, 3110000, new() { (ResourceEnum.STEEL_BAR, 2), (ResourceEnum.IRIDIUM, 1000) });
			NewAlloy(ResourceEnum.PALLADIUM_BAR, 960, 7000000, new() { (ResourceEnum.PLATINUM_BAR, 2), (ResourceEnum.PALLADIUM, 1000) });
			NewAlloy(ResourceEnum.OSMIUM_BAR, 1080, 14500000, new() { (ResourceEnum.TITANIUM_BAR, 2), (ResourceEnum.OSMIUM, 1000) });
			NewAlloy(ResourceEnum.RHODIUM_BAR, 1200, 31000000, new() { (ResourceEnum.IRIDIUM_BAR, 2), (ResourceEnum.RHODIUM, 1000) });

			//Item
			NewItem(ResourceEnum.COPPER_WIRE, 60, 10000, new() { (ResourceEnum.COPPER_BAR, 5) });
			NewItem(ResourceEnum.IRON_NAIL, 120, 20000, new() { (ResourceEnum.IRON_BAR, 5) });
			NewItem(ResourceEnum.BATTERY, 240, 70000, new() { (ResourceEnum.COPPER_WIRE, 2), (ResourceEnum.COPPER_BAR, 10) });
			NewItem(ResourceEnum.HAMMER, 480, 135000, new() { (ResourceEnum.IRON_NAIL, 2), (ResourceEnum.LEAD_BAR, 5) });
		}

		private static void NewOre(ResourceEnum type, double value)
		{
			var ore = new Resource (ClassEnum.ORE, type, value);
			ResourceLookup[type] = ore;
		}

		private static void NewAlloy(ResourceEnum type, int productionTime, double value, List<(ResourceEnum type, int quantity)> recipe)
		{
			var alloy = new Resource(ClassEnum.ALLOY, type, value, productionTime, recipe);
			ResourceLookup[type] = alloy;
		}

		private static void NewItem(ResourceEnum type, int productionTime, double value, List<(ResourceEnum type, int quantity)> recipe)
		{
			var item = new Resource(ClassEnum.ITEM, type, value, productionTime, recipe);
			ResourceLookup[type] = item;
		}

		public static Dictionary<ResourceEnum, Resource> ResourceLookup;
	}
}
