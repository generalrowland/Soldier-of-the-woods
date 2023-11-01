using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float x;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x * speed, 0, 0);

        if(Input.GetKey(KeyCode.A))            x = -1;
        else if (Input.GetKey(KeyCode.D))      x = 1;
        else                                   x = 0;
    }
}
