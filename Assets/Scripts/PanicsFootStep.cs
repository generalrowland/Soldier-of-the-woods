using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicsFootStep : MonoBehaviour
{
    public AudioSource playAudio;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        playAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
