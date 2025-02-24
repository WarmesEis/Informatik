using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Awake()
    {
        PauseMenu.SetActive (false); //PauseMenu wird ausgeblendet bis es gestartet wird
    }

    private void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("mainMenuUI");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           if (PauseMenu.activeSelf)
           {
            ResumeGame();
           }
           else
           {
            PauseGame();
           }
        }
    }
}