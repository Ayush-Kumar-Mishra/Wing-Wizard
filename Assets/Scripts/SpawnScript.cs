using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject pipePrefabs;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            var Clone = Instantiate(pipePrefabs, transform.position, Quaternion.identity);
            Destroy(Clone, 5f);
            timer = 0;
        }
    }
}
