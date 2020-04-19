using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactable
{
    public bool state;
    private StateReactor sReactor;

    void Awake()
    {
        sReactor = GetComponent<StateReactor>();
    }

    public override void Interact()
    {
        state = !state;
        if(sReactor != null)
        {
            sReactor.React();
        }
    }
}
