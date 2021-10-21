using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runtime.CombatSystem;
using GameManagement;

namespace GameManagement.PlayerManagement
{
    public class PlayerManager : Singleton<PlayerManager>
    {
        // Datos del jugador para pasar entre escenas

        private string playerName;
        //private Skin playerSkin
        private SpellDeck playerDeck;
        private int coins;
    }

}