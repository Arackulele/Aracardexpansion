using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.IO;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;


namespace AraCardExpansion
{
	public partial class Plugin
	{
		private NewAbility CreateGodability()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Call of the Gods";
			info.rulebookDescription = "When this Card is played, summon a random God in your Hand.A God is defined as: Requires Totem to exist, is incredibly powerful";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/spawngod.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility godability = new NewAbility(info, typeof(Godability), tex);
			Godability.ability = godability.ability;
			return godability;
		}
	}

	public class Godability : DrawCreatedCard
	{

		public override Ability Ability
		{
			get
			{
				return ability;
			}
		}

		public static Ability ability;

		public override CardInfo CardToDraw
		{
			get
			{
				List<string> list = new List<string> { "squirrelgod", "snake_god", "twintailed_lizard", "insect_god", "caninegod", "insect_god" };
				return CardLoader.GetCardByName(list[UnityEngine.Random.Range(0, list.Count)]);
			}
		}
	}
}
