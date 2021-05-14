using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    bool isStop = true;
    public GameObject Menu;

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);

    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void OnMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    private void Start()
    {
        Menu.SetActive(false);
    }
    void Update()
    {
        

        if (isStop == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                isStop = false;
                Menu.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                isStop = true;
                Menu.SetActive(false);
            }
        }

    }
}
