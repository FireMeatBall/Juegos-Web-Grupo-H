using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem.Spells
{
    public interface IDefensiveSpell
    {
        public void UseOnSelf(Speller target);
    } 
}
