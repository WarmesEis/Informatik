//mainMenuUI
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene ("movement");
    }

    public void CloseGame ()
    {
        if (Application.isEditor)
        {
            EditorApplication.isPlaying = false; //Wenn Editor am abspielen des spiels ist, 
                                                //wird mit der Aussage isPlaying=false und 
                                                //das Spiel wird innerhalb des Editors beendet
        }
        else
        {
            Application.Quit();
        }
    }
}
