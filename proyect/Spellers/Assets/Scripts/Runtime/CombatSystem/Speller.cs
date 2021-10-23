using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellSystem;

namespace Runtime.CombatSystem
{
    public abstract class Speller : MonoBehaviour
    {
        #region Fields

        protected SpellerStats stats;
        protected Speller target;

        #endregion

        #region Properties

        public SpellerStats Stats => stats;

        #endregion

        #region Unity CallBacks

        public void Start()
        {
            Init();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inicializa las variables necesarias
        /// </summary>
        public virtual void Init()
        {
            stats = new SpellerStats();
        }

        /// <summary>
        /// Cambia el objetivo sobre el que lanza los hechizos
        /// </summary>
        /// <param name="newTarget"> Nuevo objetivo </param>
        public void SelectTarget(Speller newTarget)
        {
            if (target != newTarget)
            {
                target = newTarget;
            }
        }
        /// <summary>
        /// Usa un hechizo
        /// </summary>
        /// <param name="spell"> Hechizo usado </param>
        public void UseSpell(Spell spell)
        {
            switch (spell.type)
            {
                case SpellSystem.Type.Attack:
                    target?.OnReceiveSpell(spell);
                    break;
                case SpellSystem.Type.Heal:
                    stats.Health += spell.lvl * 5;
                    break;
                case SpellSystem.Type.Sacrifice:
                    stats.Health -= spell.lvl * 5;
                    target?.OnReceiveSpell(spell);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Recibe un hechizo
        /// </summary>
        /// <param name="spell"> Hechizo recibido </param>
        public void OnReceiveSpell(Spell spell)
        {
            Debug.Log(gameObject.name + " -> Receive spell" + spell.name);
            switch (spell.type)
            {
                case SpellSystem.Type.Attack:
                    stats.Health -= spell.lvl * 10;
                    break;
                case SpellSystem.Type.Sacrifice:
                    stats.Health -= spell.lvl * 15;
                    break;
                default:
                    break;
            }
        }

        public abstract void LaunchSpell();

        #endregion

        #region Test and Debug

        public void TestStats()
        {
            if (target != null)
            {
                target.stats.Health -= 10;
                Debug.Log("---");
            }
        }

        #endregion
    }
}
