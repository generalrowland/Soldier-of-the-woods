using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectileM1Garand : MonoBehaviour
{
    public Transform firePosition;
    private bool isFiring;
    private float launchVelocity = 5000f;
    public GameObject Projectile;
    private bool canFire;
    private float fireTime = 0f;
    private float fireRate = 1f;
    protected Vector3 launchVector;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        launchVector = new Vector3(0, 0, launchVelocity);

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        fireTime -= Time.deltaTime;


        if(fireTime <= 0)
        {
            canFire = true;
            fireTime = 0;
        } else
        {
            canFire = false;
        }

        if (Input.GetMouseButtonDown(0) & canFire)
        {
            GameObject clone = Instantiate(Projectile, firePosition.position, firePosition.rotation);
            clone.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
            fireTime = fireRate;

            animator.SetTrigger("IsAttacking");
        }
    }

}
