using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float speed;

    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed,transform.position.y + 0);
    }

}
