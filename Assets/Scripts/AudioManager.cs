using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance {  get { return instance; } }

    public void Awake()
    {
       if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } 
       else
        {
            instance = this;
        }
       DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
