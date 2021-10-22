using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem
{
    [System.Serializable]
    public class SpellerStats
    {
        #region Fields
        const int MAX_LVL = 3;
        const int MIN_LVL = -3;
        const int MAX_HEALTH = 100;
        const int MAX_SHIELD = 50;

        private int healthPoints;
        private int shieldPoints;
        private int atqLvl;
        private int defLvl;
        private int healingLvl;

        public delegate void OnChangeHealthEvent(int health);
        public event OnChangeHealthEvent OnChangeHealth;

        public delegate void OnChangeShieldEvent(int shield);
        public event OnChangeShieldEvent OnChangeShield;

        #endregion

        #region Properties

        public int Health
        {
            get => healthPoints;
            set
            {
                int clampedValue = Mathf.Clamp(value, 0, MAX_HEALTH);
                healthPoints = clampedValue;
                OnChangeHealth?.Invoke(healthPoints);
                Debug.Log("OnChangeHealthEvent -> " + healthPoints);
            }
        }

        private int Shield
        {
            get => shieldPoints;
            set
            {
                int clampedValue = Mathf.Clamp(value, 0, MAX_SHIELD);
                shieldPoints = clampedValue;
                OnChangeShield?.Invoke(shieldPoints);
    
            }
        }

        private int AttackLevel
        {
            get => atqLvl;
            set
            {
                int clampedValue = Mathf.Clamp(value, MIN_LVL, MAX_LVL);
                atqLvl = clampedValue;
            }
        }

        private int DefenseLevel
        {
            get => defLvl;
            set
            {
                int clampedValue = Mathf.Clamp(value, MIN_LVL, MAX_LVL);
                shieldPoints = clampedValue;
            }
        }

        private int HealingLevel
        {
            get => healingLvl;
            set
            {
                int clampedValue = Mathf.Clamp(value, MIN_LVL, MAX_LVL);
                healingLvl = clampedValue;
            }
        }

        public int MAXHEALTH => MAX_HEALTH;

        #endregion

        public SpellerStats()
        {
            healthPoints = MAX_HEALTH;
        }

        public SpellerStats(int health, int atq = 0, int def = 0, int healing = 0)
        {
            healthPoints = health;
            atqLvl = atq;
            defLvl = def;
            healingLvl = healing;
        }
    }

}