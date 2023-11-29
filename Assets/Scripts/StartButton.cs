using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public bool ValidName = false;
    public UserNameInput UserInput;

    public void GameStart()
    {
        if(UserInput.UserName.text.Length > 10)
        {
            
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
