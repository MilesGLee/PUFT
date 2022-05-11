using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditManager : MonoBehaviour
{
    public int Score;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _loadText;

    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
            _loadText.SetActive(true);
        else
            _loadText.SetActive(false);
    }

    void Update()
    {
        _scoreText.text = "Score 2: " + Score;
    }

    public void AddScore() 
    {
        Score++;
    }

    public void SavePlayer() 
    {
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();
    }

    public void LoadPlayer() 
    {
        Score = PlayerPrefs.GetInt("Score");
    }
}
