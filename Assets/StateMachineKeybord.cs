using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StateMachineKeybord
{
    List<string> events = new List<string>();

    public const string left = "LEFT";
    public const string right = "RIGHT";
    public const string del = "DEL";

    public void addEvent(string ev)
    {
        events.Add(ev);
    }

    public (int cursor_position, string text) Generate()
    {
        string txt = "";
        int currsor = 0;

        int clean_up_to = 0;

        for(int i = 0; i < events.Count; i++)
        {
            string ev = events[i];

            if(ev == right)
            {
                if(currsor < txt.Length)
                {
                    currsor += 1;
                }
            }
            else if(ev == left)
            {
                if(currsor > 0)
                {
                    currsor -= 1;
                }
            }
            else if(ev == del)
            {
                if(currsor > 0)
                {
                    txt = txt.Remove((currsor - 1), 1);
                    currsor -= 1;
                }
            }
            else
            {
                txt = txt.Insert(currsor, ev);//+= ev;
                currsor += 1;
            }

            if(txt.Length == 0)
            {
                clean_up_to = i;
            }
        }

        //clear redundant events
        events.RemoveRange(0, clean_up_to);
        //Debug.Log("events : " + events.Count);

        return (currsor, txt);
    }

}
