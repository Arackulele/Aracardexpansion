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
		private NewAbility CreateBonestrafe()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Bone strafe";
			info.rulebookDescription = "Whenever this Card moves, summon a random Bone Card in its former Place.";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/bonestrafe.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility boneability = new NewAbility(info, typeof(Bonestrafe), tex);
			Bonestrafe.ability = boneability.ability;
			return boneability;
		}
	}

	public class Bonestrafe : Strafe
	{

		public override Ability Ability
		{
			get
			{
				return ability;
			}
		}


		public static Ability ability;


		public override IEnumerator PostSuccessfulMoveSequence(CardSlot cardSlot)
		{
			if (cardSlot.Card == null)
			{
				List<string> list = new List<string> { "Opossum", "Opossum", "Cockroach", "Bat", "Maggots", "Maggots" };
				name = list[UnityEngine.Random.Range(0, list.Count)];
				yield return Singleton<BoardManager>.Instance.CreateCardInSlot(CardLoader.GetCardByName(name), cardSlot, 0.1f, true);
			}
			yield break;
		}
	}
}

