using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    public static ScoreManager Instance {  get { return _instance; } }
    private int currentPoints = 0;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + currentPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + currentPoints.ToString();
    }

    public void AddPoints(int pointsToAdd)
    {
        currentPoints += pointsToAdd;
    }
}
