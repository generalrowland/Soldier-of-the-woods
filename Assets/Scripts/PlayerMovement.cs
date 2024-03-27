using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 1;
    private float xRange = 98;
    private float zRange = 93;
    private float horizontal;
    private float vertical;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)

            animator.SetBool("IsMoving", true);
        else

            animator.SetBool("IsMoving", false);

        transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime); 

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }

    public void MoveInput(Vector2 newMoveDir)
    {
        horizontal = value.Get<Vector2>().x;
        vertical = value.Get<Vector2>().y();
    }
}
