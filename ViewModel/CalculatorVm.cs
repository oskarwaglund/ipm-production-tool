using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using IpmProductionTool.Model;
using Microsoft.AspNetCore.Components;

namespace IpmProductionTool.ViewModel
{
	public class CalculatorVm : BaseViewModel, ICalculatorVm
	{

		public class ListItem
		{
			public string Name;
			public List<(string name, int quantity)> Recipe;
			public ListItem(string name, List<(string name, int quantity)> recipe)
			{
				Name = name;
				Recipe = recipe;
			}

			public override string ToString()
			{
				string res = Name + " | ";
				foreach(var i in Recipe)
				{
					res += i.name + " " + i.quantity + ", ";
				}
				res = res.Substring(0, res.Length - 2);
				return res;
			}
		}	
		public List<MarkupString> GetAlloys(int underforgeLevel, int dormsLevel)
		{
			return GetList(Resources.ClassEnum.ALLOY, underforgeLevel, dormsLevel);
		}

		public List<MarkupString> GetItems(int underforgeLevel, int dormsLevel)
		{
			return GetList(Resources.ClassEnum.ITEM, underforgeLevel, dormsLevel);
		}

		private List<MarkupString> GetList(Resources.ClassEnum classEnum, int underforgeLevel, int dormsLevel)
		{
			var calc = new Calculator(underforgeLevel, dormsLevel);
			var res = new List<MarkupString>();
			Resources.GetResource(Resources.ResourceEnum.COPPER); //TODO
			foreach (var t in Resources.ResourceLookup.Values.Where(t => t.Class == classEnum))
			{
				var re = calc.GetResourceEvaluation(t.Type);
				var neededOre = re.OreUsage;
				var markup = "<tr>";
				markup += $"<td>{re.Name}</td>";
				markup += $"<td>${SciNot(re.Value)}</td>";
				markup += $"<td>${SciNot(re.OreValue)}</td>";
				markup += $"<td>{MultiplierAsPercent(re.OreValueIncrease)}</td>";
				markup += $"<td>{re.SmeltTime} s</td>";
				markup += $"<td>{re.CraftTime} s</td>";
				markup += $"<td></td>";
				markup += $"<td></td>";
				markup += $"<td>{"    " + String.Join(", ", neededOre.Select(a => a.quantity + " " + Resources.NameOf(a.type)).ToArray())}</td>";
				markup += "</tr>";
				res.Add(new MarkupString(markup));
			}

			return res;
		}

		private string SciNot(double value)
		{
			var sciNot = value.ToString("E1", CultureInfo.InvariantCulture);
			var split = sciNot.Split('E');
			return split[0] + "E" + int.Parse(split[1]);
		}

		private string MultiplierAsPercent(double multiplier)
		{
			if (multiplier == 1) return "0%";
			else if(multiplier > 1)
			{
				int inc = (int)Math.Round((multiplier - 1.0) * 100);
				return "+" + inc + "%";
			}
			else
			{
				int dec = (int)Math.Round((1.0 - multiplier) * 100);
				return "-" + dec + "%";
			}
		}
	}
}
