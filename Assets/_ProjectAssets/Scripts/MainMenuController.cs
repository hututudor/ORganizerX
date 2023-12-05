using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartPracticeMode()
    {
        SceneManager.LoadScene("OR");
    }
    
    public void StartTestMode()
    {
        SceneManager.LoadScene("OR");
    }
}
