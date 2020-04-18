using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [HideInInspector] public Collider col;
    public Transform cameraPosition;
    public List<Node> relevantNodes = new List<Node>();

    // Start is called before the first frame update
    void Start()
    {       
        col = this.gameObject.GetComponent<Collider>();
        Debug.Log("Awoke Collider" + col);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {    
        Arrive();
    }

    public void Arrive()
    {
        //Leave the last Node and arrive at the next one
        if (GameManager.ins.currentNode != null) GameManager.ins.currentNode.Leave();

        GameManager.ins.currentNode = this;

        Camera.main.transform.position = cameraPosition.position;
        Camera.main.transform.rotation = cameraPosition.rotation;

        if(col != null)
        {
            col.enabled = false;
        }

        foreach(Node n in relevantNodes)
        {
            if(n.col != null)
            {
                n.col.enabled = true;
            }
        }
    }

    public void Leave()
    {
        foreach (Node n in relevantNodes)
        {
            if (n.col != null)
            {
                n.col.enabled = false;
            }
        }
    }
}
