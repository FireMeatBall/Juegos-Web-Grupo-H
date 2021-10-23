using UnityEngine;
using System.Collections.Generic;
using SpellSystem;
using System;
using System.Linq;

namespace Runtime.CombatSystem
{
    [SerializeField]
    public class SpellTable
    {
        private int selectedSpell;
        private List<Spell> spellSlots;
        private SpellDeck deck;
        private Board board;

        public delegate void OnChangeSlotEvent(int id, Spell spell);
        public OnChangeSlotEvent OnChangeSlot;

        public SpellTable(SpellDeck deck)
        {
            this.deck = deck;
            spellSlots = new List<Spell>(3);
            GenerateSpellSlots();
        }


        public void GenerateSpellSlots()
        {
            spellSlots.Clear();
            var rand = new System.Random();
            spellSlots.AddRange(deck.spells.OrderBy(x => rand.Next()).Take(3));
            OnChangeSlot?.Invoke(0, spellSlots[0]);
            OnChangeSlot?.Invoke(1, spellSlots[1]);
            OnChangeSlot?.Invoke(2, spellSlots[2]);

        }

        public void SelectSlot(int n)
        {
            Debug.Log("Player -> Select spell nº" + n + " ( " + spellSlots[n].spellName + " " + spellSlots[n].lvl + ")");
            selectedSpell = n;
        }

        public Spell UseSpell()
        {
            Spell s = spellSlots[selectedSpell];
            spellSlots[selectedSpell] = deck.spells[new System.Random().Next(deck.spells.Count)];
            OnChangeSlot?.Invoke(selectedSpell, spellSlots[selectedSpell]);
            return s;
        }

        public void UpdateUI()
        {
            OnChangeSlot?.Invoke(0, spellSlots[0]);
            OnChangeSlot?.Invoke(1, spellSlots[1]);
            OnChangeSlot?.Invoke(2, spellSlots[2]);
        }

    }
}