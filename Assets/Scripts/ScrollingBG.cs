using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public MeshRenderer mr;
    public float speed;

    void Update()
    {
        mr.material.mainTextureOffset = new Vector2(speed * Time.time, 0);
    }
}
