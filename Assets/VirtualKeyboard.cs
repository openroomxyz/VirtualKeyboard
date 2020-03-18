using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class VirtualKeyboard : MonoBehaviour
{
    public  UnityEngine.UI.InputField InputField;
    private StateMachineKeybord sm;

    private void Start()
    {
        sm = new StateMachineKeybord();
        InputField.readOnly = true;
    }

    public void KeyPress(string c) { sm.addEvent(c); }
    public void KeyLeft() { sm.addEvent(StateMachineKeybord.left); }
    public void KeyRight() { sm.addEvent(StateMachineKeybord.right); }
    public void KeyDelete() { sm.addEvent(StateMachineKeybord.del); }
    private string Cursor() { return ((Time.timeSinceLevelLoad % 0.5f) < 0.25f) ? "|" : ""; }
    private void Update()
    {
        (int currsor_pos, string txt) = sm.Generate();
        InputField.text = (txt == "") ? Cursor() + " " : txt.Substring(0, currsor_pos) + Cursor() + txt.Substring(currsor_pos);
    }
}
