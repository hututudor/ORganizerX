using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("OR");
    }
    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
