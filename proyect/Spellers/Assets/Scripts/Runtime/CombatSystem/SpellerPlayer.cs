using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellSystem;

namespace Runtime.CombatSystem
{
    public class SpellerPlayer : Speller
    {
        public SpellTable table;

        [SerializeField] List<Spell> spells;

        public override void Init()
        {
            base.Init();

            SpellDeck deck = new SpellDeck(spells);
            table = new SpellTable(deck);
        }


        /// <summary>
        /// Usa el hechizo seleccionado en la mesa
        /// </summary>
        public override void LaunchSpell()
        {
            UseSpell(table.UseSpell());
        }

        /// <summary>
        /// Selecciona el hechizo en la posición idx de la mesa
        /// </summary>
        /// <param name="idx"> Posición seleccionada </param>
        public void SelectSpell(int idx)
        {
            table.SelectSlot(idx);
        }
    } 
}
