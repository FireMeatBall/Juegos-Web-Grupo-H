using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem
{
    public abstract class Spell
    {
        protected string spellName;
        protected int lvl;

        public abstract void Use(SpellerStats user, SpellerStats target);
    }

    // Offensive Spells:
    public class AttackSpell : Spell
    {
        private int ComputeDamage(SpellerStats target)
        {
            return (int)(target.MAXHEALTH * 0.025f + 0.025f * lvl);
        }

        public override void Use(SpellerStats user, SpellerStats target)
        {
            int points = ComputeDamage(target);
            target.Health -= points;
        }

    }

    public class SacrificeSpell : Spell
    {
        public override void Use(SpellerStats user, SpellerStats target)
        {
            int points = ComputeDamage(target);
            target.Health -= points;
            user.Health -= (points - 15);
        }

        protected int ComputeDamage(SpellerStats target)
        {
            return (int)(target.MAXHEALTH * 0.225f + 0.025f * lvl);
        }
    }

    // Healing Spells:
    public class HealingSpell : Spell
    {
        private int ComputeDamage(SpellerStats target)
        {
            return (int)(target.MAXHEALTH * 0.02f + 0.02f * lvl);
        }

        public override void Use(SpellerStats user, SpellerStats target)
        {
            int points = ComputeDamage(target);
            user.Health += points;
        }
    }



}