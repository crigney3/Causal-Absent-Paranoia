using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateReactor : MonoBehaviour
{
    public Switcher switcher;

    protected virtual void Awake()
    {
        switcher.change += React;
        React();
    }

    public virtual void React()
    {
        Debug.Log(name + "'s State is " + switcher.state);
    }
}
