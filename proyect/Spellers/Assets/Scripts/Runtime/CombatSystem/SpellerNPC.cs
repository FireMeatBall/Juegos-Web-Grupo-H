using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellSystem;

namespace Runtime.CombatSystem
{
    public class SpellerNPC : Speller
    {
        [SerializeField] private List<Spell> spells_list;

        public override void LaunchSpell()
        {
            Spell s = spells_list[new System.Random().Next(spells_list.Count)];
            UseSpell(s);
            Debug.Log(gameObject.name + ": Use spell " + s.ToString() + "seconds...");
        }

        public override void Init()
        {
            base.Init();

            target = FindObjectOfType<SpellerPlayer>();
            Debug.Log(spells_list.Count);
            StartNewCounter();
        }

        IEnumerator SpellCooldown(float time)
        {
            Debug.Log(gameObject.name + ": Waiting for " + time + "seconds...");
            yield return new WaitForSeconds(time);
            LaunchSpell();
            StartNewCounter();
        }

        public void StartNewCounter()
        {
            IEnumerator corroutine = SpellCooldown(Random.Range(5, 15));
            StartCoroutine(corroutine);
        }

        
    }
}
