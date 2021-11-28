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
		private NewAbility CreateSharpDam()
		{
			AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
			info.powerLevel = 5;
			info.rulebookName = "Sharp Dams";
			info.rulebookDescription = "Creates 2 Sharpened Dams Adjancent to this Card.Sharp Dams are defined as: 0 Power, 2 Health,inherit Sharp Sigil";
			info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/damability.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);

			NewAbility sharpdams = new NewAbility(info, typeof(SharpDam), tex);
			SharpDam.ability = sharpdams.ability;
			return sharpdams;
		}
	}
		public class SharpDam : CreateCardsAdjacent
		{

			public override Ability Ability
			{
				get
				{
					return ability;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x0600133E RID: 4926 RVA: 0x0004376C File Offset: 0x0004196C
			public override string SpawnedCardId
			{
				get
				{
					return "dam_sharp";
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x0600133F RID: 4927 RVA: 0x00043773 File Offset: 0x00041973
			public override string CannotSpawnDialogue
			{
				get
				{
					return "Blocked on both sides. No Dams for your Beaver.";
				}
			}
		public static Ability ability;
	}

}
