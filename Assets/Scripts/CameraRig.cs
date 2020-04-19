using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRig : MonoBehaviour
{
    public Transform yAxis;
    public Transform xAxis;
    public float moveTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void alignTo(Transform t)
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(yAxis.DOMove(t.position, moveTime));
        seq.Join(yAxis.DORotate(new Vector3(0f, t.rotation.eulerAngles.y, 0f), moveTime));
        seq.Join(xAxis.DOLocalRotate(new Vector3(t.rotation.eulerAngles.x, 0f, 0f), moveTime));
    }
}
