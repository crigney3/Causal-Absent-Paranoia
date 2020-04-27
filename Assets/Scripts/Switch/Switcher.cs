using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactable
{
    public bool state;
    private StateReactor sReactor;
    public delegate void OnStateChange();
    public event OnStateChange change;

    void Awake()
    {

    }

    public override void Interact()
    {
        state = !state;
        if(change != null)
        {
            change();
        }
    }
}
