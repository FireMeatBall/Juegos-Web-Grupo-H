using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace SpellSystem
{
    public class SpellManager : Singleton<SpellManager>
    {
        public static List<Spell> spells;

        public static Spell GetSpell(int idx)
        {
            if (idx < spells.Count)
                return spells[idx];
            else
                throw new System.Exception();
        }

    }

}