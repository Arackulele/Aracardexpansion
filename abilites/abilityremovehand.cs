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
		private NewAbility CreateRemoveHand()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Empty Hands";
			info.rulebookDescription = "when a Card bearing this sigil is played, it removes all cards in your hand";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/removehand.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility removehand = new NewAbility(info, typeof(RemoveHand), tex);
			RemoveHand.ability = removehand.ability;
			return removehand;
		}
	}
	public class RemoveHand : AbilityBehaviour
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x000438CB File Offset: 0x00041ACB
		public override Ability Ability
		{
			get 
			{
				return ability;
			}
		}

		public static Ability ability;

		// Token: 0x06001364 RID: 4964 RVA: 0x0000F57E File Offset: 0x0000D77E
		public override bool RespondsToResolveOnBoard()
		{
			return true;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000438CF File Offset: 0x00041ACF
		public override IEnumerator OnResolveOnBoard()
		{
			yield return base.PreSuccessfulTriggerSequence();
			yield return new WaitForSeconds(0.25f);
			List<PlayableCard> list = Singleton<PlayerHand>.Instance.CardsInHand.FindAll((PlayableCard x) => x != Singleton<PlayerHand>.Instance.ChoosingSlotCard);
			while (list.Count > 0)
			{
				list[0].SetInteractionEnabled(false);
				list[0].Anim.PlayDeathAnimation(true);
				UnityEngine.Object.Destroy(list[0].gameObject, 1f);
				Singleton<PlayerHand>.Instance.RemoveCardFromHand(list[0]);
				list.RemoveAt(0);

			}
		}
	}
}
