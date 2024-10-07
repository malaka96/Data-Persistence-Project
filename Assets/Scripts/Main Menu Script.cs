using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TMP_InputField _playerNameInput;
    public TMP_Text _nameText;
    public static string _playerName;

    void Start()
    {
       // Debug.Log(PlayerPrefs.GetString(_userName, "User"));
    }


    void Update()
    {
        _nameText.text = $"Best Score: {PlayerPrefs.GetString("_userName", "User")} : {PlayerPrefs.GetInt("_playerScore", 0)}";
    }

    public void GetPlayerName()
    {
        _playerName = _playerNameInput.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DeleteSavingDate()
    {
        PlayerPrefs.DeleteAll();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
