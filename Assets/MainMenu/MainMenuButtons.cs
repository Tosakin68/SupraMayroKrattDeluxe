using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject mainmenucanvas;
    public GameObject characterselectcanvas;
    public static int character = 0;

    public void StartGame()
    {
        mainmenucanvas.GetComponent<Canvas>().enabled = false;
        characterselectcanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MayroSelect()
    {
        character = 0;
    }
    public void LuggySelect()
    {
        character = 1;
    }
    public void JoshySelect()
    {
        character = 2;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
