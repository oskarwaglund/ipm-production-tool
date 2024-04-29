using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IpmProductionTool.Model.Resources;

namespace IpmProductionTool.Model
{
	//Everything in this class is calculated with upgrades applied
	public class ResourceEvaluation
	{
		public string Name { get; set; }
		public double Value { get; set; }
		public double OreValue { get; set; }
		public double OreValueIncrease => Value / OreValue;
		public int SmeltTime { get; set; }
		public int CraftTime { get; set; }
		public int ProductionTime => SmeltTime + CraftTime;
		public List<(ResourceEnum type, int quantity)> OreUsage;
	}
}
