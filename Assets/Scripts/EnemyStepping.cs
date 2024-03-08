using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStepping : MonoBehaviour
{
    public AudioClip footSteps;
    public AudioSource audioSource;

    // Start is called before the first frame update
    public void PlayFootSteps()
    {
        audioSource.PlayOneShot(footSteps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
