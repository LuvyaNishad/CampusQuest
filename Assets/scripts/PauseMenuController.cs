using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [Header("Main Panels")]
    public GameObject mainMenuPanel;
    public GameObject pauseMenu;
    public GameObject optionsPanel;
    public GameObject questPanel;

    [Header("Player")]
    public PlayerMovement playerMoveScript;
    public MobilePlayerMovement mobilePlayerMoveScript;

    private bool isPaused = false;

    void Start()
    {
        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);

        if (pauseMenu != null)
            pauseMenu.SetActive(false);
        if (optionsPanel != null)
            optionsPanel.SetActive(false);
        if (questPanel != null)
            questPanel.SetActive(false);

        ResumeGame();
    }

    void Update()
    {
        Debug.Log("Pause Controller Running");

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("TAB PRESSED");
            if (isPaused)
                ResumeGame();
            else
                OpenPauseMenu();
        }
    }

    public void OpenPauseMenu()
    {
        Debug.Log("BUTTON CLICKED - OpenPauseMenu called");
        isPaused = true;

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);

        pauseMenu.SetActive(true);

        if (optionsPanel != null)
            optionsPanel.SetActive(false);
        if (questPanel != null)
            questPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;

        if (playerMoveScript != null)
            playerMoveScript.SetCanMove(false);
        if (mobilePlayerMoveScript != null)
            mobilePlayerMoveScript.SetCanMove(false);
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);

        if (optionsPanel != null)
            optionsPanel.SetActive(false);
        if (questPanel != null)
            questPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;

        if (playerMoveScript != null)
            playerMoveScript.SetCanMove(true);
        if (mobilePlayerMoveScript != null)
            mobilePlayerMoveScript.SetCanMove(true);
    }

    public void OpenOptions()
    {
        if (optionsPanel != null)
            optionsPanel.SetActive(true);
        if (questPanel != null)
            questPanel.SetActive(false);
    }

    public void OpenQuests()
    {
        if (questPanel != null)
            questPanel.SetActive(true);
        if (optionsPanel != null)
            optionsPanel.SetActive(false);
    }

    // NEW — closes whichever sub-panel is open and returns to the PAUSED screen
    public void BackToPauseMenu()
    {
        if (optionsPanel != null)
            optionsPanel.SetActive(false);
        if (questPanel != null)
            questPanel.SetActive(false);
        if (pauseMenu != null)
            pauseMenu.SetActive(true);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}