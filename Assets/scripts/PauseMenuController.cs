using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [Header("Main Panels")]
    public GameObject pauseMenu;
    public GameObject optionsPanel;
    public GameObject questPanel;

    [Header("Player")]
    public PlayerMovement playerMoveScript;

    private bool isPaused = false;

    void Start()
    {
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

    // =========================
    // OPEN MENU
    // =========================

    public void OpenPauseMenu()
    {
        isPaused = true;

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
    }

    // =========================
    // RESUME GAME
    // =========================

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
    }

    // =========================
    // OPTIONS TAB
    // =========================

    public void OpenOptions()
    {
        if (optionsPanel != null)
            optionsPanel.SetActive(true);

        if (questPanel != null)
            questPanel.SetActive(false);
    }

    // =========================
    // QUEST TAB
    // =========================

    public void OpenQuests()
    {
        if (questPanel != null)
            questPanel.SetActive(true);

        if (optionsPanel != null)
            optionsPanel.SetActive(false);
    }

    // =========================
    // EXIT GAME
    // =========================

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}