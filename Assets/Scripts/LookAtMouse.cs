using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        player.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}

