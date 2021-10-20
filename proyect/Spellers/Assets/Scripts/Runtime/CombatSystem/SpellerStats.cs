using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem
{
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
        #endregion

        #region Properties

        public int Health
        {
            get => healthPoints;
            set
            {
                int clampedValue = Mathf.Clamp(value, 0, MAX_HEALTH);
                healthPoints = clampedValue;
            }
        }

        private int Shield
        {
            get => shieldPoints;
            set
            {
                int clampedValue = Mathf.Clamp(value, 0, MAX_SHIELD);
                shieldPoints = clampedValue;
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
            shieldPoints = 0;
            atqLvl = 0;
            defLvl = 0;
            healingLvl = 0;
        }
    }

}