using UnityEngine;
using System.Collections.Generic;
using Runtime.CombatSystem.Spells;
using System;

namespace Runtime.CombatSystem
{
    public class SpellTable
    {
        private int selectedSpell;
        private List<Spell> spellSlots;
        private SpellDeck deck;
        private Board board;

        public SpellTable(SpellDeck deck)
        {
            this.deck = deck;
        }


        public void GenerateSpellSlots()
        {
             
        }

        public void SelectSlot(int n)
        {
            selectedSpell = n;
            

        }

    }
}