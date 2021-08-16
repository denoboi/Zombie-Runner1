using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
   public void ReloadGame()
    {
        SceneManager.LoadScene(0); 
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}