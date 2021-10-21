using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime.CombatSystem
{
    public class Speller : MonoBehaviour
    {
        public SpellerStats playerstats;
        public SpellTable table;

        // Start is called before the first frame update
        void Start()
        {
            //table = new SpellTable();
            playerstats = new SpellerStats();
        }
    } 
}
