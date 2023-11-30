using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvlCanvas : MonoBehaviour
{
    [SerializeField] GameObject[] Stars;
    [SerializeField] TextMeshProUGUI TimeText;
    [SerializeField] GameObject Canvas;

    private void Start()
    {
        for (int i = 0; i < Stars.Length; i++)
        {
            Stars[i].SetActive(false);
        }
        Canvas.SetActive(false);

        Time.timeScale = 1.0f;
    }


    public void ReturnMenu() 
    {
        SceneManager.LoadScene(0);
    }
    
    
    public void NextLevel() 
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex;
        var AllCountScene = SceneManager.sceneCountInBuildSettings;

        if (SceneIndex + 1 < AllCountScene) 
        {
            SceneManager.LoadScene(SceneIndex + 1);
        }
        Debug.Log("next LVL");
    }



    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void EnableCanvas(float time, int stars) 
    {
        Canvas.SetActive(true);
        TimeText.SetText(time.ToString());

        for(int i = 0; i < stars; i++) 
        {
            Stars[i].SetActive(true);
        }
    }
}
