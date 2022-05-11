using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class FileManager : MonoBehaviour
{
    public int Score;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _loadText;

    void Start()
    {
        string path = Application.persistentDataPath + "/file.txt";
        Debug.Log(path);
        if (File.Exists(path))
        {
            _loadText.SetActive(true);
        }
        else 
        {
            _loadText.SetActive(false);
        }
    }

    private void Update()
    {
        _scoreText.text = "Score: " + Score;
    }

    public void SavePlayer()
    {
        FileSaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        FileData data = FileSaveSystem.LoadPlayer();

        Score = data.Score;
    }

    public void AddScore() 
    {
        Score++;
    }
}
