using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class MainMenuUI : MonoBehaviour
{
    public void SceneChange(int NuberScene) 
    {
        SceneManager.LoadScene(NuberScene);
    }


    public void QuitGame() 
    {
        Application.Quit();   
    }



}

