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
		private NewAbility CreateFishstrafe()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Fish strafe";
			info.rulebookDescription = "Whenever this Card moves, it leaves a Fish in its former place.Go fish!";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/fishability.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility fishability = new NewAbility(info, typeof(Fishstrafe), tex);
			Fishstrafe.ability = fishability.ability;
			return fishability;
		}
	}

	public class Fishstrafe : Strafe
	{
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000444B8 File Offset: 0x000426B8
		public override Ability Ability
		{
			get
			{
				return ability;
			}
		}


		public static Ability ability;

		// Token: 0x06001419 RID: 5145 RVA: 0x000444BC File Offset: 0x000426BC
		public override IEnumerator PostSuccessfulMoveSequence(CardSlot cardSlot)
		{
			if (cardSlot.Card == null)
			{
				yield return Singleton<BoardManager>.Instance.CreateCardInSlot(CardLoader.GetCardByName("fish"), cardSlot, 0.1f, true);
			}
			yield break;
		}
	}
}
