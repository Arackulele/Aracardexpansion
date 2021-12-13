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
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
	public partial class Plugin : BaseUnityPlugin
	{
		private const string PluginGuid = "arackulele.inscryption.aracardexpansion";
		private const string PluginName = "AraCardExpansion";
		private const string PluginVersion = "3.1.1";

		private void Awake()
		{
			Logger.LogInfo($"Loaded {PluginName}!");

			CreateGodabilitySquirrel();
			CreateGodabilitylizard();
			CreateGodabilitybird();
			CreateGodabilityhooved();
			CreateGodabilitywolf();
			CreateGodabilitybug();

			CreateFishstrafe();
            CreateBonestrafe();
			CreateSharpDam();
			CreateRemoveHand();
			CreateArmyspawn();
			CreateMenacing();
			CreateVampiric();


			AddAncient_being();
			Addanthill();
			Addaugmented_geck();
			Addbeast();
			Addbeast_2();
			Addbeast_3();
			Addbig_ant();
			Addbird_god();
			AddBlobfish();
			Addnotbug();
			AddBullet_ant();
			Addbush_elk();
			Addcaninegod();
			AddSnake_corn();
			Addcrow();
			Addcorpsewalker();
			Addelk_old();
			AddFly_trap();
			Addhoovedgod();
			Addinsect_god();
			AddElk_leader();
			AddMites();
			Addsmallmoon();
			Addowl();
			Addsnake_god();
			Addriverbird();
			Addriverbird_water();
			AddScreeching_ant();
			Addsmall_ant();
			AddSoldier_ant();
			AddSpider();
			AddSquid();
			Addsquirrelgod();
			Addsun_priestess();
			Addhole();
			AddThornyDevil();
			Addtwintailed_lizard();
			Addreanimator();
			Addundeaddog();
			AddVicious_Beaver();
			Addwarriorsquirrel();
			Addwasp();
			Addfish();
			Adddam_sharp();
			Addunknown_army();
			Addtotem_bird();
			Addtotem_lizard();
			Addtotem_squirrel();
			Addtotem_wolf();
			Addtotem_bug();
			Addtotem_hoove();
		}
		private void Addtotem_bird()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(Godabilitybird.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_bird.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_bird", "Tribal Totem", 0, 5, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "A log, capable of summoning the God of Aviation, how did the Woodcarver do this.", bloodCost: 2, bonesCost: 0, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex);
		}

		private void Addtotem_hoove()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(Godabilityhooved.ability);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_hoove.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_hoove", "Wild Totem", 0, 2, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "A giant Crystal emmiting an odd smell, the Hooved God is fond of it.", bloodCost: 0, bonesCost: 3, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex);
		}

		private void Addtotem_squirrel()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(GodabilitySquirrel.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_squirrel.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_squirrel", "Acorn Totem", 0, 8, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "An Acorn Tree growing on a Tree stump, the Squirrel Gods habitat.", bloodCost: 2, bonesCost: 0, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex);
		}

		private void Addtotem_lizard()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(Godabilitylizard.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_lizard.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_lizard", "Totem of Tails", 0, 2, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "A giant construct with a Tail ominously hovering over it, perhaps part of the Lizard God.", bloodCost: 1, bonesCost: 0, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex);
		}
		private void Addtotem_bug()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(Godabilitybug.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_bug.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_bug", "Totem of Insectoids", 0, 3, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "A Giant Bone carved to look like a Totem.Attracts the God of Insects.", bloodCost: 0, bonesCost: 2, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex);
		}

		private void Addtotem_wolf()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Gem);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GainGemOrange);
			abilities.Add(Godabilitywolf.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/totem_wolf.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("totem_wolf", "Totem of Souls", 1, 5, metaCategories, CardComplexity.Simple, CardTemple.Nature, description: "A Billion Souls in one Piece of Wood, The Canine Gods shrine.", bloodCost: 2, bonesCost: 0, energyCost: 0, traits: traits, abilities: abilities, defaultTex: tex, appearanceBehaviour: appearanceBehaviour);
		}

		private void AddAncient_being()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sacrificial);
			abilities.Add(Menacing.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/NO.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Ancient_being", "Ancient Being", 0, 5, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"I dont think i made this, but you can choose it if you please.", bloodCost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addanthill()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.IceCube);
			abilities.Add(Ability.DrawAnt);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/anthill.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("anthill", "Anthill", 0, 3, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"Theres a Bunch of ants hiding in this, their Kingdom will not last for long.", bloodCost:3, bonesCost:0, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, defaultTex:tex, iceCubeId:new IceCubeIdentifier("AntQueen"));
		}

		private void Addaugmented_geck()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.SwapStats);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/augmented_geck.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
											// move name and two numbers after first String
			NewCard.Add("augmented_geck", "Augmented Geck", 1, 5, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"This is not a Geck, this is THE Geck.", bloodCost:2, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addbeast()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beast_1.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("beast", "Beast", 0, 2, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"Thou shall not awaken this Creature", bloodCost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex, evolveId:new EvolveIdentifier("beast_2",1));
		}

		private void Addbeast_2()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beast_2.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("beast_2", "Waking Beast", 1, 4, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"lets hope this works!", bloodCost:1, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex, evolveId:new EvolveIdentifier("beast_3",1));
		}

		private void Addbeast_3()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Deathtouch);
			abilities.Add(Ability.Sharp);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beast_3.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("beast_3", "Awoken Beast", 6, 6, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"oh my fucking god", bloodCost:0, bonesCost:6, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex);
		}

		private void Addbig_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.SplitStrike);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/giant_ant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("big_ant", "Giant Ant", 1, 5, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"True creature of gaming.", bloodCost:1, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, defaultTex:tex,tribes:tribes);
		}

		private void Addbird_god()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Flying);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/flying_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("bird_god","God of Flight", 4, 2,  metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The Flying God,gracefully it circles its prey.", bloodCost:1, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddBlobfish()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Fishstrafe.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/blobfish.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Blobfish", "Blobfish", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Useless Creature, you can have it.Why does it look like that?", bloodCost:1, bonesCost:0, abilities:abilities, defaultTex:tex);
		}

		private void Addnotbug()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Squirrel);
			tribes.Add(Tribe.Bird);
			tribes.Add(Tribe.Canine);
			tribes.Add(Tribe.Hooved);
			tribes.Add(Tribe.Reptile);
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.ExplodeOnDeath);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/bug.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("notbug", "Bug?", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Im not quite sure if this is actually a bug.", bloodCost:2, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddBullet_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.CorpseEater);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/bulletant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Bullet_ant","Bullet Ant", 0, 1,  metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"An eerie ctreature, seems to enjoy the company of other Ants.", bloodCost:0, bonesCost:6, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, defaultTex:tex,tribes:tribes);
		}

		private void Addbush_elk()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Hooved);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sniper);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/bushelk.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("bush_elk", "Bush Elk", 1, 1, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"A coward.The Bush Elk does not care for rules", bloodCost:1, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addcaninegod()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Canine);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.PreventAttack);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/canine_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("caninegod", "Canine God", 4, 1, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"Seeing this dreaded Creature will melt your Bones, better close your eyes!", bloodCost:2, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddSnake_corn()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawCopy);
			abilities.Add(Ability.BoneDigger);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/cornsnake.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Snake_corn", "Corn Snake", 2, 1, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The boring Corn Snake,it never comes alone and it loves Bones.", bloodCost:0, bonesCost:6, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addcrow()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(CreateRemoveHand().ability);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/crow.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("crow", "Crow", 3, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The unlucky Crow may prove as a strategical advantage in some cases.", bloodCost:1, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addcorpsewalker()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Armyspawn.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/corpsewalker.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("corpsewalker", "Corpsewalker", 2, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Akin to the Necromancer, the Corpsewalker makes Cards die twice, it is a little more unpredicatble however.", bloodCost:0, bonesCost:5, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex);
		}

		private void Addelk_old()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Hooved);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Strafe);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/elk_old.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("elk_old", "Old Elk", 1, 3, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"huiofrdsguhhuzgtfh", bloodCost:0, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddFly_trap()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.SteelTrap);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/flytrap.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Fly_trap", "Fly Trap", 0, 2, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"Not a creature, but a Plant.Do not tread on it", bloodCost:0, bonesCost:3, abilities:abilities, defaultTex:tex);
		}


		private void Addhoovedgod()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Hooved);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.StrafePush);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/hoofed_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("hoovedgod", "Hooved God", 3, 12, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"A being more wise and more experienced than any other, the Hooved God is not to mess with.", bloodCost:2, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addinsect_god()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.TriStrike);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/Insect_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("insect_god", "Insect God", 1, 1, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The Reptile God, it rules over the Tribe.", bonesCost:4, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddElk_leader()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Hooved);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);
			abilities.Add(Ability.Deathtouch);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/elk_alpha.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Elk_leader", "Alpha Elk", 3, 3, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The Alpha Elk, incredibly strong but not for long.", bloodCost:2, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex, evolveId:new EvolveIdentifier("elk_old",1));
		}

		private void AddMites()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Brittle);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/mites.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Mites", "Mites", 1, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Small Creatures,i dont think they will be of much use.", bloodCost:0, bonesCost:1, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addsmallmoon()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.AllStrike);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/the_moon_smol.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("smallmoon", "Mini Moon", 2, 8, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"A tiny recreation of a Moon, an interesting Card.", bloodCost:4, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex);
		}

		private void Addowl()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Reach);
			abilities.Add(Menacing.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/owl.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("owl", "Owl", 2, 2, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"The angry Owl, it glides down to hit its prey picking off Bones.", bloodCost:2, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addsnake_god()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.TailOnHit);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/snake_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("snake_god", "Reptile God", 4, 2, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The Reptile God, it rules over the Tribe.", bonesCost:4, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addriverbird()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/river_bird_air.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("riverbird","Riverbird", 1, 2,  metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"The vicious Riverbird, it dives every other Turn to attack directly.", bloodCost:1, bonesCost:0, abilities:abilities, defaultTex:tex, evolveId:new EvolveIdentifier("riverbird_water",1), tribes: tribes);
		}

		private void Addriverbird_water()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);
			abilities.Add(Ability.Submerge);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/river_bird_water.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("riverbird_water", "Riverbird", 1, 2, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"The vicious Riverbird, it dives every other Turn to attack directly.", bloodCost:1, bonesCost:0, abilities:abilities, defaultTex:tex, evolveId:new EvolveIdentifier("riverbird",1),tribes:tribes);
		}



		private void AddScreeching_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawCopy);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/screechant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Screeching_ant", "Screeching Ant", 0, 2, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"When this Creature Screams, there will soon be more.", bloodCost:2, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, defaultTex:tex,tribes:tribes);
		}

		private void Addsmall_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/tinyant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("small_ant", "Tiny Ant", 0, 1, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"A laughable creature,soon it will become a little bit less laughable.", bloodCost:1, bonesCost:0, abilities:abilities, defaultTex:tex, traits: traits, evolveId:new EvolveIdentifier("big_ant",2),tribes:tribes);
		}

		private void AddSoldier_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sniper);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/workerant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Soldier_ant", "Ant Soldier", 0, 3, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"A strengthy member of the colony,used to doing the heavy lifting.", bloodCost:2, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, abilities:abilities, defaultTex:tex, specialAbilities: specialAbilities, tribes: tribes);
		}

		private void AddSpider()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Vampiric.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/spoodar.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Spider", "Spider", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The fragile Spider,no matter what is done it seems to always stand up again.", bloodCost:1, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void AddSquid()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Submerge);
			abilities.Add(Ability.Sniper);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/squid.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Squid", "Inky Squid", 2, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Lurking in the Shadows, the Squid is quite formidable.", bloodCost:0, bonesCost:6, abilities:abilities, defaultTex:tex);
		}

		private void Addsquirrelgod()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Squirrel);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawVesselOnHit);
			abilities.Add(Ability.GemDependant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/Squirrel_GOd.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("squirrelgod", "God of Squirrels", 1, 10, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"The God of Squirrels,made up of 1000 Squirrels.It shall not be killed.", bloodCost:1, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addsun_priestess()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sniper);
			abilities.Add(Ability.TriStrike);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/sun_priestess.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("sun_priestess", "Sun Priestess", 1, 4, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"Do not underestimate this being of pure Power.", bloodCost:3, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex);
		}

		private void Addhole()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Submerge);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Mirror);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/hole.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("hole", "The abyss", 0, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The abyss, an endless fall.", bonesCost:4, specialStatIcon:SpecialStatIcon.Mirror, specialAbilities:specialAbilities, abilities:abilities, defaultTex:tex);
		}

		private void AddThornyDevil()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sharp);
			abilities.Add(Menacing.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/thorny_devil.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("ThornyDevil", "Thorny Devil", 1, 4, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The Defending Thorny Devil, attacking this Beast wont prove as an advantage.", bloodCost:2, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addtwintailed_lizard()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.TailOnHit);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/twintailed_lizard.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("twintailed_lizard", "Twintailed Lizard", 3, 6, metaCategories, CardComplexity.Advanced, CardTemple.Nature, description:"The Twintailed Lizard, a creature of Immense Power.", bloodCost:3, tribes:tribes, abilities:abilities, defaultTex:tex);
		}

		private void Addreanimator()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.QuadrupleBones);
			abilities.Add(Bonestrafe.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/reanimator.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("reanimator", "Reanimator", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The Reanimator animates the Dead, summoning Skeletons along its path.", bloodCost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, defaultTex:tex);
		}

		private void Addundeaddog()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Canine);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Bonestrafe.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/dog.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("undeaddog", "Reanimators Dog", 1, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The remains of a Guarding Dog, the Reanimator revived it a long time ago.", bloodCost:0, bonesCost:5, abilities:abilities, defaultTex:tex, tribes:tribes);
		}

		private void AddVicious_Beaver()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(SharpDam.ability);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beaver.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Vicious_Beaver", "Vicious Beaver", 1, 2, metaCategories, CardComplexity.Vanilla, CardTemple.Nature, description:"A cruel Creature, creating Spiked Dams it kills its prey", bloodCost:2, bonesCost:0, abilities:abilities, defaultTex:tex);
		}

		private void Addwarriorsquirrel()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Squirrel);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.IceCube);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/angrysquirrel.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("warriorsquirrel", "Warrior Squirrel", 1, 1, metaCategories, CardComplexity.Simple, CardTemple.Nature, description:"The Squirrels are sick of being sacrificed.", bloodCost:1, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex, iceCubeId:new IceCubeIdentifier("Squirrel"));
		}

		private void Addwasp()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Menacing.ability);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/Wasp_Insect.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("wasp", "Wasp", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description:"The prideful Wasp, her underlings are the Bees.", bloodCost:1, bonesCost:0, tribes:tribes, abilities:abilities, defaultTex:tex);
		}
		private void Addfish()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Submerge);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/fish.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("fish", "Fish.", 0, 1, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description: "Fish.", bloodCost: 0, bonesCost: 0, defaultTex: tex, abilities:abilities);
		}

		private void Adddam_sharp()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sharp);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/sharp_dams.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("dam_sharp", "Sharp Dam", 0, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description: "thisisunused.", bloodCost: 0, bonesCost: 0, defaultTex: tex, abilities: abilities, appearanceBehaviour: appearanceBehaviour);
		}

		private void Addunknown_army()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.RandomAbility);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/unknown_army.png"));
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			NewCard.Add("unknownarmy", "Army of the Unknown", 1, 2, metaCategories, CardComplexity.Intermediate, CardTemple.Nature, description: "thisisunused.", bloodCost: 1, bonesCost: 0, defaultTex: tex, abilities: abilities);
		}

	}
}
