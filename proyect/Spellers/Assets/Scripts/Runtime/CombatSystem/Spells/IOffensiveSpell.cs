using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem.Spells
{
    public interface IOffensiveSpell
    {
        public void useOnTarget(Speller target);
    } 
}
