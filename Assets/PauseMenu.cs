using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pauseMenu.activeSelf)
                {
                    // Menu is open — resume the game
                    Time.timeScale = 1f;
                    pauseMenu.SetActive(false);
                    Cursor.visible = false;
                }
                else
                {
                    // Menu is closed — pause the game
                    Time.timeScale = 0f;
                    pauseMenu.SetActive(true);
                    Cursor.visible = true;
                }
            }
        }

    public void quit()
    {
        Application.Quit();
    }

    public void resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }
}