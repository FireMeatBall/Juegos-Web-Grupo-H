using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem.Spells
{
    public interface IMultitargetSpell
    {
        public void UseOnTargets(IEnumerable<Speller> targets);
    }
}
