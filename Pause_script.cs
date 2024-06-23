using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_script : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject WinMenu;
    public AppleCounter ac;
    public Animator anim;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        WinMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1f;
            }
            else
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        WinMenu.SetActive(false);
        ac.apples = 0;
        ps.Stop();
        anim.SetBool("Open", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
