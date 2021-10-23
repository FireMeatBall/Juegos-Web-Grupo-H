using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpellSystem;

namespace Runtime.CombatSystem
{
    public class SpellTableGUI : MonoBehaviour
    {
        public List<Text> txt_spells;
        public SpellTable spellTable;

        public void Start()
        {
            spellTable = gameObject.GetComponent<SpellerPlayer>().table;
            spellTable.OnChangeSlot += SetSpellText;
            spellTable.UpdateUI();
        }

        public void SetSpellText(int n, Spell spell)
        {
            txt_spells[n].text = spell.ToString();
        }
    }

}