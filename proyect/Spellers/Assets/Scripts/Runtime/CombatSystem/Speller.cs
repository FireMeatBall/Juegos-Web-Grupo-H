using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runtime.CombatSystem.Spells;

namespace Runtime.CombatSystem
{
    public abstract class Speller : MonoBehaviour
    {
        public SpellerStats stats;
        private Speller target;

        // Start is called before the first frame update
        

        public void OnUseSpell(Spell spell)
        {
            // Usa el hechizo 
        }

        public void OnSelectTarget(Speller newTarget)
        {
            if(target != newTarget)
            {
                target = newTarget;
            }
        }

        public void Start()
        {
            Init();
        }

        public virtual void Init()
        {
            stats = new SpellerStats();            
        }

        [ContextMenu("TextStats")]
        public void TestStats()
        {
            if(target != null)
            {
                target.stats.Health -= 10;
            }            
        }
    } 
}
