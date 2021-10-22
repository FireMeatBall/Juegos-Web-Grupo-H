using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runtime.CombatSystem.Spells;

namespace Runtime.CombatSystem
{
    public class SpellerPlayer : Speller
    {
        private SpellTable table;


        public override void Init()
        {
            base.Init();
            table = new SpellTable(new SpellDeck());
        }
    } 
}
