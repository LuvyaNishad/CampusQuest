using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [Header("Main Panels")]
    public GameObject mainMenuPanel;   // NEW — drag MainMenuPanel here in Inspector
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
            mainMenuPanel.SetActive(true);   // NEW — always keep the container on

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
            mainMenuPanel.SetActive(true);   // NEW — force parent on every time, no dependency on Tab's side effect

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

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}