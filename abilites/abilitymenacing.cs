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
		private NewAbility CreateMenacing()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Menacing";
			info.rulebookDescription = "Whenever this Card is damaged,various small Creatures may flock in your hand.";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/menacing.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility menacing = new NewAbility(info, typeof(Menacing), tex);
			Menacing.ability = menacing.ability;
			return menacing;
		}
	}

	public class Menacing : DrawCreatedCard
	{

		public override Ability Ability
		{
			get
			{
				return ability;
			}
		}

		public static Ability ability;

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x000433C6 File Offset: 0x000415C6
		public override CardInfo CardToDraw
		{
			get
			{
				List<string> list = new List<string> { "Squirrel", "Rabbit", "Bee", "fish" };
				return CardLoader.GetCardByName(list[UnityEngine.Random.Range(0, list.Count)]);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0000F57E File Offset: 0x0000D77E
		public override bool RespondsToTakeDamage(PlayableCard source)
		{
			return true;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000433D2 File Offset: 0x000415D2
		public override IEnumerator OnTakeDamage(PlayableCard source)
		{
			yield return base.PreSuccessfulTriggerSequence();
			base.Card.Anim.StrongNegationEffect();
			yield return new WaitForSeconds(0.4f);
			yield return base.CreateDrawnCard();
			yield return base.LearnAbility(0.5f);
			yield break;
		}
	}
}
