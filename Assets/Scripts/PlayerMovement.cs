using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 12;
    private float xRange = 308;
    private float zRange = 285;
    private float horizontal;
    private float vertical;
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (horizontal != 0 || vertical != 0)
        {
            animator.SetBool("IsMoving", true);
        }

            
        else
        {
            animator.SetBool("IsMoving", false);
            rb.velocity = Vector3.zero;
        }

        if (rb.velocity.x> 5)
        {
            rb.velocity = new Vector3(5,rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.z > 5)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5);
        }


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

        //transform.Translate((horizontal * transform.right + vertical * transform.forward) * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rb.AddForce((horizontal * transform.right) * speed * Time.deltaTime, ForceMode.Impulse); 
        rb.AddForce((vertical * transform.forward ) * speed * Time.deltaTime, ForceMode.Impulse); 
    }

    public void MoveInput(Vector2 newMoveDir)
    {
        newMoveDir = newMoveDir.normalized;
        horizontal = newMoveDir.x;
        vertical = newMoveDir.y;
    }

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }
}
