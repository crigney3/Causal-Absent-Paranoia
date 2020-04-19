using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Item))]
public abstract class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Interact()
    {
        Debug.Log("a");
    }
}
