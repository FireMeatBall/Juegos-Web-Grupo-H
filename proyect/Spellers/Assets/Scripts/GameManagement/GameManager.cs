using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManagement
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        public void Awake() => instance = this;

        public static void LoadScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }

        private void Start()
        {
            DontDestroyOnLoad(this);
        }


    } 
}
