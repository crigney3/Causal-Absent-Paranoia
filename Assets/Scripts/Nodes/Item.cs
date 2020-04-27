using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Node
{
    public Location loc;
    Interactable inter;

    void Start()
    {
        inter = GetComponent<Interactable>();
    }
    public override void Arrive()
    {
        if(inter != null && inter.enabled)
        {
            inter.Interact();
            return;
        }

        base.Arrive();

        if(inter != null)
        {
            if(GetComponent<Prereq>() != null && !GetComponent<Prereq>().Complete)
            {
                return;
            }
            col.enabled = true;
            inter.enabled = true;
        }
    }

    public override void Leave()
    {
        base.Leave();

        if(inter != null)
        {
            inter.enabled = false;
        }
    }
}
