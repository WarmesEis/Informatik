using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMenuUI : MonoBehaviour
{
    public GameObject mapMenu;
    private void Awake()
    {
        mapMenu.SetActive(false);
    }

    private void MenuSelection()
    {
        mapMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartMap()
    {
        Time.timeScale = 1;
        mapMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("mainMenuUI");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           if (mapMenu.activeSelf)
           {
            StartMap();
           }
           else
           {
            MenuSelection();
           }
        }
    }
}
