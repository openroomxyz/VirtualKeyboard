using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    const string del = "DEL";
    const string right = "RIGHT";
    const string left = "LEFT";

    [SerializeField] private VirtualKeyboard keybord;

    private void OnMouseDown()
    {
        if(transform.name == del)
        {
            keybord.KeyDelete();
        }
        else if(transform.name == right)
        {
            keybord.KeyRight();
        }
        else if(transform.name == left)
        {
            keybord.KeyLeft();
        }
        else
        {
            keybord.KeyPress(transform.name);
        }
        
    }
}
