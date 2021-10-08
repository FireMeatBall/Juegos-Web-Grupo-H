using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public enum ArrowType
    {
        left = 0,
        up = 1,
        right = 2
    }

    public Text text;

    public void OnClickKey(int index)
    {
        text.text = "Key " + index;
    }

    public void OnClickArrow(int type)
    {
        text.text = "Arrow " + ((ArrowType) type).ToString();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            OnClickArrow(0);
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnClickArrow(1);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnClickArrow(2);
        }
    }
}
