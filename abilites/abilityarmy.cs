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
		private NewAbility CreateArmyspawn()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Unknown Army";
			info.rulebookDescription = "When a Card bearing this Sigil is played, all empty Spaces are filled with the Unknown Army.";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/armyability.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility armyspawn = new NewAbility(info, typeof(Armyspawn), tex);
			Armyspawn.ability = armyspawn.ability;
			return armyspawn;
		}
	}

	public class Armyspawn : AbilityBehaviour
	{

		public override Ability Ability
		{
			get
			{
				return ability;
			}
		}

		public static Ability ability;

		public override bool RespondsToResolveOnBoard()
		{
			return true;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000433ED File Offset: 0x000415ED
		public override IEnumerator OnResolveOnBoard()
		{
			Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, false);
			yield return base.PreSuccessfulTriggerSequence();
			foreach (CardSlot cardSlot in Singleton<BoardManager>.Instance.AllSlots)
			{
				if (cardSlot.Card == null)
				{
					yield return Singleton<BoardManager>.Instance.CreateCardInSlot(CardLoader.GetCardByName("unknownarmy"), cardSlot, 0.15f, false);
				}
			}
			List<CardSlot>.Enumerator enumerator = default(List<CardSlot>.Enumerator);
			yield return base.LearnAbility(0.5f);
			yield break;
			yield break;
		}
	}
}
