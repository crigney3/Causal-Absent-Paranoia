using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageViewer : Interactable
{
    public Sprite pic;
    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        GameManager.ins.ivCan.Activate(pic);
    }
}
