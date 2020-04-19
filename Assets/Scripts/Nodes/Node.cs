using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Node : MonoBehaviour
{
    [HideInInspector] public Collider col;
    public Transform cameraPosition;
    public List<Node> relevantNodes = new List<Node>();

    // Start is called before the first frame update
    void Awake()
    {       
        col = this.gameObject.GetComponent<Collider>();
        col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {    
        Arrive();
    }

    public virtual void Arrive()
    {
        //Leave the last Node and arrive at the next one
        if (GameManager.ins.currentNode != null) GameManager.ins.currentNode.Leave();

        GameManager.ins.currentNode = this;

        GameManager.ins.cameraRig.alignTo(cameraPosition);

        if(col != null)
        {
            col.enabled = false;
        }

        SetReachableNodes(true);
    }

    public virtual void Leave()
    {
        SetReachableNodes(false);
    }

    public void SetReachableNodes(bool value)
    {
        foreach (Node n in relevantNodes)
        {
            if (n.col != null)
            {
                n.col.enabled = value;
            }
        }
    }
}
