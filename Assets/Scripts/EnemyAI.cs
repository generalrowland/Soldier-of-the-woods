using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent ai;
    public Animator anim;
    public float enemyHealth;
    private bool isMoving;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        ai = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //ai.SetDestination(target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            enemyHealth -= 5;
            Debug.Log("Hit Enemy");

            if (enemyHealth > 0)
                anim.SetTrigger("IsHit");
            else
            {
                anim.SetTrigger("IsDead");
                Destroy(gameObject, 30);
                ScoreManager.Instance.AddPoints(13);
            }
            if (enemyHealth <= 0)
            {
                ai.enabled = false;
            }
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("IsAttacking");
            collision.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")&& target != null && ai.isActiveAndEnabled)
        {
            ai.SetDestination(target.transform.position);
            if(isMoving==false) 
                anim.SetBool("IsMoving", true);
        }
    }
}
