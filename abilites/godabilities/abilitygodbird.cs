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
		private NewAbility CreateGodabilitybird()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Call of the Gods[Avian]";
			info.rulebookDescription = "When this Card is played, summon the Flying God in your Hand.";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/spawngod.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility godabilitybird = new NewAbility(info, typeof(Godabilitybird), tex);
			Godabilitybird.ability = godabilitybird.ability;
			return godabilitybird;
		}
	}

	public class Godabilitybird : DrawCreatedCard
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
				List<string> list = new List<string> { "bird_god" };
				return CardLoader.GetCardByName(list[UnityEngine.Random.Range(0, list.Count)]);
			}
		}
		public override bool RespondsToResolveOnBoard()
		{
			return true;
		}

		public override IEnumerator OnResolveOnBoard()
		{
			yield return base.PreSuccessfulTriggerSequence();
			yield return base.CreateDrawnCard();
			yield return base.LearnAbility(0f);
			yield break;
		}
	}
}
