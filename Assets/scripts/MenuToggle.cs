using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject menuPanel;
    public MonoBehaviour playerMoveScript;

    bool menuOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuOpen = !menuOpen;
            menuPanel.SetActive(menuOpen);

            if (menuOpen)
            {
                // OPEN SOUND
                SoundManager.instance.PlayChestOpen();

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0f;

                playerMoveScript.enabled = false;
            }
            else
            {
                // CLOSE SOUND
                SoundManager.instance.PlayChestClose();

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale = 1f;

                playerMoveScript.enabled = true;
            }
        }
    }
}
