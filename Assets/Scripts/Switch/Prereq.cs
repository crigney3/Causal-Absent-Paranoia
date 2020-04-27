using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prereq : MonoBehaviour
{
    public Switcher watchSwitcher;

    public bool Complete
    {
        get
        {
            return watchSwitcher.state;
        }
    }
}
