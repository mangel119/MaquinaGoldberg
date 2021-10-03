using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementstair : MonoBehaviour
{
     // Start is called before the first frame update
    public Vector3 dir;
    public float speed;
    public float posicionU;
    public float posicionD;

    void Start()
    {
        dir = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
        if (transform.position.y >= posicionU)
        {
            dir = Vector3.down;
        }

        if (transform.position.y <= posicionD)
        {
            dir = Vector3.up;
        }
    }

}
