using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootProjectile : MonoBehaviour
{
    private Transform firePosition;
    private bool isFiring;
    private float launchVelocity = 50f;
    public GameObject Projectile;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(Projectile, firePosition.position, firePosition.rotation);
            clone.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
        }
    }

}
