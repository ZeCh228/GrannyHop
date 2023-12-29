using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] GameObject VictoryMenu;
    [SerializeField] PlayerHealth PlayerHealth;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PlayerHealth.InProcessRespawn == true) return;
            if (VictoryMenu.activeSelf) return;
            if (SettingsMenu.activeSelf)
            {
                SettingsMenu.SetActive(false);
                Menu.SetActive(true);
            }
            else if (!Menu.activeSelf)
            {
                Menu.SetActive(true);
                Time.timeScale = 0f;
                Cursor.visible = true;
            }
            else
            {
                Continue();
            }
        }
    }


    public void Continue()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}