using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ShootProjectilePistol : MonoBehaviour
{
    public Transform firePosition;
    private bool isFiring;
    public float launchVelocity = 5000f;
    public GameObject Projectile;
    public bool canFire;
    private float fireTime = 0f;
    private float fireRate = 0.2f;
    protected Vector3 launchVector;
    private Animator animator;
    public AudioSource gunSource;

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

        if (isFiring & canFire)
        {
            Invoke("Fire", 0.35f);
            isFiring = false;
            animator.SetTrigger("IsAttacking");
        }
    }

    public virtual void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(firePosition.position, firePosition.forward * launchVelocity);
    }

    void Fire()
    {
        gunSource.Play();
        GameObject clone = Instantiate(Projectile, firePosition.position, firePosition.rotation);
        clone.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
        fireTime = fireRate;
    }

    public void FireInput(bool newFireState)
    {
        isFiring = true;
    }

    public void OnFire(InputValue value)
    {
        FireInput(value.isPressed);
    }

}
