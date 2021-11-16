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
	public class Plugin : BaseUnityPlugin
	{
		private const string PluginGuid = "arackulele.inscryption.aracardexpansion";
		private const string PluginName = "AraCardExpansion";
		private const string PluginVersion = "1.8.0";

		private void Awake()
		{
			Logger.LogInfo($"Loaded {PluginName}!");

			AddAncient_being();
			Addanthill();
			Addaugmented_geck();
			Addbeast();
			Addbeast_2();
			Addbeast_3();
			Addbig_ant();
			AddBlobfish();
			Addnotbug();
			AddBullet_ant();
			Addbush_elk();
			Addcanine_god();
			AddSnake_corn();
			Addcrow();
			Addcorpsewalker();
			Addelk_old();
			AddFly_trap();
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
			Addsun_priestess();
			AddThornyDevil();
			Addtwintailed_lizard();
			Addreanimator();
			Addundeaddog();
			AddVicious_Beaver();
			Addwarriorsquirrel();
			Addwasp();
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
			abilities.Add(Ability.TripleBlood);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/NO.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Ancient_being", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Ancient Being", 0, 2, description:"I dont think i made this, but you can choose it if you please.", cost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("anthill", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Anthill", 0, 3, description:"Theres a Bunch of ants hiding in this, their Kingdom will not last for long.", cost:3, bonesCost:0, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, tex:tex, iceCubeId:new IceCubeIdentifier("AntQueen"));
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
			NewCard.Add("augmented_geck", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Augmented Geck", 1, 5, description:"This is not a Geck, this is THE Geck.", cost:2, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addbeast()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beast_1.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("beast", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Beast", 0, 2, description:"Thou shall not awaken this Creature", cost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("beast_2",1));
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
			NewCard.Add("beast_2", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Waking Beast", 1, 4, description:"lets hope this works!", cost:1, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("beast_3",1));
		}

		private void Addbeast_3()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Deathtouch);
			abilities.Add(Ability.PreventAttack);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beast_3.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("beast_3", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Awoken Beast", 6, 6, description:"oh my fucking god", cost:0, bonesCost:6, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex);
		}

		private void Addbig_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.SplitStrike);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/giant_ant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("big_ant", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Giant Ant", 1, 5, description:"True creature of gaming.", cost:1, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, tex:tex);
		}

		private void AddBlobfish()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.SquirrelStrafe);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/blobfish.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Blobfish", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Blobfish", 1, 2, description:"Useless Creature, you can have it.Why does it look like that?", cost:1, bonesCost:0, abilities:abilities, tex:tex);
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
			NewCard.Add("notbug", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Bug?", 1, 2, description:"Im not quite sure if this is actually a bug.", cost:2, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void AddBullet_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.CorpseEater);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/bulletant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Bullet_ant", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Bullet Ant", 0, 1, description:"An eerie ctreature, seems to enjoy the company of other Ants.", cost:0, bonesCost:6, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, tex:tex);
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
			NewCard.Add("bush_elk", metaCategories, CardComplexity.Simple, CardTemple.Nature, "Bush Elk", 1, 1, description:"A coward.The Bush Elk does not care for rules", cost:1, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addcanine_god()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Canine);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.PreventAttack);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/canine_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("canine_god", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Canine God", 2, 1, description:"Seeing this Creature will make your Bones melt.The Canine God is truly Powerful", cost:3, bonesCost:0, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("Snake_corn", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Corn Snake", 2, 1, description:"The boring Corn Snake,it never comes alone and it loves Bones.", cost:0, bonesCost:6, appearanceBehaviour:appearanceBehaviour, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addcrow()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawNewHand);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/crow.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("crow", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Crow", 3, 2, description:"The unlucky Crow may prove as a strategical advantage in some cases.", cost:1, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addcorpsewalker()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DoubleDeath);
			abilities.Add(Ability.RandomAbility);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/corpsewalker.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("corpsewalker", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Corpsewalker", 1, 2, description:"Akin to the Necromancer, the Corpsewalker makes Cards die twice, it is a little more unpredicatble however.", cost:0, bonesCost:5, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex);
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
			NewCard.Add("elk_old", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Old Elk", 1, 3, description:"huiofrdsguhhuzgtfh", cost:0, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("Fly_trap", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Fly Trap", 0, 2, description:"Not a creature, but a Plant.Do not tread on it", cost:0, bonesCost:3, abilities:abilities, tex:tex);
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
			NewCard.Add("Elk_leader", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Alpha Elk", 3, 3, description:"The Alpha Elk, incredibly strong but not for long.", cost:2, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("elk_old",1));
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
			NewCard.Add("Mites", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Mites", 1, 1, description:"Small Creatures,i dont think they will be of much use.", cost:0, bonesCost:1, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("smallmoon", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Mini Moon", 2, 8, description:"A tiny recreation of a Moon, an interesting Card.", cost:4, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex);
		}

		private void Addowl()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Bird);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Sharp);
			abilities.Add(Ability.BoneDigger);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/owl.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("owl", metaCategories, CardComplexity.Simple, CardTemple.Nature, "Owl", 2, 2, description:"The angry Owl, it glides down to hit its prey picking off Bones.", cost:2, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addsnake_god()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Reptile);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DeathShield);
			abilities.Add(Ability.TailOnHit);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/snake_god.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("snake_god", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Reptile God", 1, 1, description:"The Reptile God,a protector by trait.", bonesCost:4, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addriverbird()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/river_bird_air.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("riverbird", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Riverbird", 1, 2, description:"The vicious Riverbird,it dives every other Turn to attack directly.", cost:1, bonesCost:0, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("riverbird_water",1));
		}

		private void Addriverbird_water()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.GBCPack);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);
			abilities.Add(Ability.Submerge);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/river_bird_water.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("riverbird_water", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Riverbird", 1, 2, description:"The vicious Riverbird,it dives every other Turn to attack directly.", cost:1, bonesCost:0, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("riverbird",1));
		}

		private void AddScreeching_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Trait> traits = new List<Trait>();
			traits.Add(Trait.Ant);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawCopy);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/screechant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Screeching_ant", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Screeching Ant", 0, 2, description:"When this Creature Screams, there will soon be more.", cost:2, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, tex:tex);
		}

		private void Addsmall_ant()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.Evolve);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/tinyant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("small_ant", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Tiny Ant", 0, 1, description:"A laughable creature,soon it will become a little bit less laughable.", cost:1, bonesCost:0, abilities:abilities, tex:tex, evolveId:new EvolveIdentifier("big_ant",2));
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

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/workerant.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Soldier_ant", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Ant Soldier", 0, 3, description:"A strengthy member of the colony,used to doing the heavy lifting.", cost:2, bonesCost:0, specialStatIcon:SpecialStatIcon.Ants, traits:traits, specialAbilities:specialAbilities, abilities:abilities, tex:tex);
		}

		private void AddSpider()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.DrawCopyOnDeath);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/spoodar.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Spider", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Spider", 0, 2, description:"The fragile Spider,no matter what is done it seems to always stand up again.", cost:1, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("Squid", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Inky Squid", 2, 1, description:"Lurking in the Shadows, the Squid is quite formidable.", cost:0, bonesCost:6, abilities:abilities, tex:tex);
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
			NewCard.Add("sun_priestess", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Sun Priestess", 1, 4, description:"Do not underestimate this being of pure Power.", cost:3, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex);
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
			abilities.Add(Ability.Sharp);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/thorny_devil.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("ThornyDevil", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Thorny Devil", 1, 4, description:"The Defending Thorny Devil, attacking this Beast wont prove as an advantage.", cost:2, tribes:tribes, abilities:abilities, tex:tex);
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
			NewCard.Add("twintailed_lizard", metaCategories, CardComplexity.Advanced, CardTemple.Nature, "Twintailed Lizard", 3, 6, description:"The Twintailed Lizard, a creature of Immense Power.", cost:3, tribes:tribes, abilities:abilities, tex:tex);
		}

		private void Addreanimator()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.QuadrupleBones);
			abilities.Add(Ability.SkeletonStrafe);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/reanimator.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("reanimator", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Reanimator", 1, 2, description:"The Reanimator animates the Dead, summoning Skeletons along its path.", cost:2, bonesCost:0, appearanceBehaviour:appearanceBehaviour, abilities:abilities, tex:tex);
		}

		private void Addundeaddog()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.GuardDog);
			abilities.Add(Ability.QuadrupleBones);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/dog.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("undeaddog", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Undead Dog", 1, 2, description:"The remains of a Guarding Dog, a sad fate awaits it.", cost:0, bonesCost:5, abilities:abilities, tex:tex);
		}

		private void AddVicious_Beaver()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.CreateDams);
			abilities.Add(Ability.BuffNeighbours);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/beaver.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("Vicious_Beaver", metaCategories, CardComplexity.Vanilla, CardTemple.Nature, "Vicious Beaver", 1, 1, description:"A cruel Creature, creating Spiked Dams it kills its prey", cost:2, bonesCost:0, abilities:abilities, tex:tex);
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
			NewCard.Add("warriorsquirrel", metaCategories, CardComplexity.Simple, CardTemple.Nature, "Warrior Squirrel", 1, 1, description:"The Squirrels are sick of being sacrificed.", cost:1, bonesCost:0, tribes:tribes, abilities:abilities, tex:tex, iceCubeId:new IceCubeIdentifier("Squirrel"));
		}

		private void Addwasp()
		{
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> tribes = new List<Tribe>();
			tribes.Add(Tribe.Insect);

			List<Ability> abilities = new List<Ability>();
			abilities.Add(Ability.BeesOnHit);
			abilities.Add(Ability.Flying);

			byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll",""),"Artwork/Wasp_Insect.png"));
			Texture2D tex = new Texture2D(2,2);
			tex.LoadImage(imgBytes);
			NewCard.Add("wasp", metaCategories, CardComplexity.Intermediate, CardTemple.Nature, "Wasp", 1, 3, description:"The prideful Wasp, her underlings are the Bees.", cost:0, bonesCost:6, tribes:tribes, abilities:abilities, tex:tex);
		}

	}
}
