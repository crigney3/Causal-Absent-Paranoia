using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MirrorInitializer : MonoBehaviour
{
    public RenderTexture rt;
    public Camera cam;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        rt = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
        rt.Create();

        cam = this.gameObject.transform.GetChild(0).GetComponent<Camera>();
        cam.targetTexture = rt;

        mat = new Material(Shader.Find("Sprites/Default"));
        mat.mainTextureScale = new Vector2(0.5f, 0.5f);
        mat.mainTexture = rt;

        this.gameObject.GetComponent<MeshRenderer>().sharedMaterial = mat;
    }
}
