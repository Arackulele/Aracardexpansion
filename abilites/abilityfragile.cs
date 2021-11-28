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
        private NewAbility CreateVampiric()
        {
            AbilityInfo info = ScriptableObject.CreateInstance<AbilityInfo>();
            info.powerLevel = 5;
            info.rulebookName = "Carnivore";
            info.rulebookDescription = "For each point of damage this Creature deals to another, it will be healed by 1.";
            info.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular };

            byte[] imgBytes = System.IO.File.ReadAllBytes(Path.Combine(this.Info.Location.Replace("AraCardExpansion.dll", ""), "Artwork/vampiric.png"));
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(imgBytes);

            NewAbility vampire = new NewAbility(info, typeof(Vampiric), tex);
            Vampiric.ability = vampire.ability;
            return vampire;
        }
    }

    public class Vampiric : AbilityBehaviour
    { 


     public override Ability Ability
    {
        get
        {
            return ability;
        }
    }

    public static Ability ability;

        public override bool RespondsToDealDamage(int amount, PlayableCard target)
        {
            return amount > 0;
        }

        public override IEnumerator OnDealDamage(int amount, PlayableCard target)
        {
            yield return base.PreSuccessfulTriggerSequence();
            if (base.Card.Status.damageTaken > 0)
            {
                base.Card.HealDamage(Mathf.Clamp(amount, 1, base.Card.Status.damageTaken));
            }
            base.Card.OnStatsChanged();
            base.Card.Anim.StrongNegationEffect();
            yield return new WaitForSeconds(0.25f);
            yield return base.LearnAbility(0.25f);
            yield break;
        }



    }

}