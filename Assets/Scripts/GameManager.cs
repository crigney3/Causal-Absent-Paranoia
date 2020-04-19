using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    [HideInInspector] public Node currentNode;
    public Node startingNode;
    public CameraRig cameraRig;
    public IVCanvas ivCan;
    public ObservCamera obsCamera;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        currentNode = startingNode;
        currentNode.Arrive();
    }

    void Awake()
    {
        ins = this;
        ivCan.gameObject.SetActive(false);
        obsCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1) && currentNode.GetComponent<Item>() != null)
        {
            if (ivCan.gameObject.activeInHierarchy)
            {
                ivCan.Close();
                return;
            }
            else if (obsCamera.gameObject.activeInHierarchy)
            {
                obsCamera.Close();
                return;
            }
            currentNode.GetComponent<Item>().loc.Arrive();
        }
    }
}
