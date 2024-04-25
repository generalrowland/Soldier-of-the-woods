using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DeathManager : MonoBehaviour
{
    public GameObject toSelect;
    public string[] deathQuotes;
    public TextMeshProUGUI quoteLabel;

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(toSelect);
        quoteLabel.text = deathQuotes[Random.Range(0, deathQuotes.Length)];
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
