using UnityEngine.UI;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    private int level;

    public Text text;
    
    public void SelectLevel(int n)
    {
        Debug.Log("Level " + n + " selected");
        level = n;
        text.text = "Nivel " + n;
    }


}
