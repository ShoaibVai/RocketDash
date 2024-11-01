using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGloop : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRenderer;

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0,-bgSpeed*Time.deltaTime);
    }
}
