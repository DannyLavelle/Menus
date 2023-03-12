using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] string PlayScene = "TestSpace";
    [SerializeField] string MainMenuScene = "StartScene";
    [SerializeField] GameObject OptionsMenuPanel;
    [SerializeField] GameObject PauseMenuPanel;
    [SerializeField] bool IsPauseMenuAvailable=false;
    [HideInInspector] public static bool IsGamePaused = false;

    void Update()
    {
        PauseMenu();
    }
    void PauseMenu()
    {
        if (IsPauseMenuAvailable == true)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (IsGamePaused)
                {
                    Resume();

                }
                else
                {
                    Pause();
                }
            }
        }
    }
    void Pause()
    {
        Cursor.visible = true;
        PauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;

    }
   public void Resume()
    {
        Cursor.visible = false;
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }
    public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(PlayScene);

    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        Resume();
        Cursor.visible = true;
        SceneManager.LoadScene(MainMenuScene);
    }
    public void OptionsOpen()
    {
        OptionsMenuPanel.SetActive(false);
    }
    public void OptionsClose()
    {
        OptionsMenuPanel.SetActive(true);
    }
}
