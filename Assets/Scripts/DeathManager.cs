using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public string[] deathQuotes;
    public TextMeshProUGUI quoteLabel;

    // Start is called before the first frame update
    void Start()
    {
        quoteLabel.text = deathQuotes[Random.Range(0, deathQuotes.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
