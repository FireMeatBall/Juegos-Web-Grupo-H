using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem.Spells
{
    public class HealingSpell : Spell, IDefensiveSpell
    {
        const float BASE = 0.5f;
        const float INCREMENT = 0.025f;

        public void UseOnSelf(Speller target)
        {
            int points = (int)(BASE + INCREMENT * lvl * 0.5f);
            target.stats.Health += points;
        }
    }

}


