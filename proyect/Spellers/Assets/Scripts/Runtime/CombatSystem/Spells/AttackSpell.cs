using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem.Spells
{
    public class AttackSpell : Spell, IOffensiveSpell
    {
        const float BASE = 0.5f;
        const float INCREMENT = 0.025f;

        public void useOnTarget(Speller target)
        {
            int points = (int)(BASE + INCREMENT * lvl);
            target.playerstats.Health -= points;
        }
    }

}


