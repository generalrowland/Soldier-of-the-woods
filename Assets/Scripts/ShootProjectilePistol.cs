using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectilePistol : MonoBehaviour
{
    public Transform firePosition;
    private bool isFiring;
    public float launchVelocity = 50f;
    public GameObject Projectile;
    public bool canFire;
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


        if (fireTime <= 0)
        {
            canFire = true;
            fireTime = 0;
        }
        else
        {
            canFire = false;
        }

        if (Input.GetMouseButtonDown(0) & canFire)
        {
            Invoke("Fire", 0.35f);

            animator.SetTrigger("IsAttacking");
        }
    }

    void Fire()
    {
        GameObject clone = Instantiate(Projectile, firePosition.position, firePosition.rotation);
        clone.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
        fireTime = fireRate;

    }
}
