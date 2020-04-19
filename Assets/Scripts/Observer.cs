using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : Interactable
{
    public override void Interact()
    {
        GameObject item = Instantiate(gameObject);
        item.transform.SetParent(GameManager.ins.obsCamera.transform.GetChild(0).transform);
        item.transform.localPosition = Vector3.zero;
        item.transform.GetChild(0).transform.localPosition = Vector3.zero;
        GameManager.ins.obsCamera.model = item.transform;
        GameManager.ins.obsCamera.gameObject.SetActive(true);
        Debug.Log(item.transform.position);
    }
}
