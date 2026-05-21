using UnityEngine;
using TMPro;

public class TeleportDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Transform player;
    public GameObject menuPanel;

    public MonoBehaviour mouseLookScript;
    public MonoBehaviour playerMoveScript;

    public void TeleportPlayer(int value)
    {
        if (player == null)
        {
            Debug.LogError("Player not assigned!");
            return;
        }

        Vector3 targetPos = player.position;

        switch (value)
        {
            case 0: return;

            case 1: targetPos = new Vector3(611, 2, 553); break;
            case 2: targetPos = new Vector3(680, 2, 450); break;
            case 3: targetPos = new Vector3(379, 2, 374); break;
            case 4: targetPos = new Vector3(680, 2, 530); break;
            case 5: targetPos = new Vector3(236, 2, 411); break;
            case 6: targetPos = new Vector3(520, 2, 470); break;
            case 7: targetPos = new Vector3(700, 2, 520); break;
            case 8: targetPos = new Vector3(730, 2, 490); break;
            case 9: targetPos = new Vector3(610, 2, 430); break;
            case 10: targetPos = new Vector3(760, 2, 550); break;
            case 11: targetPos = new Vector3(800, 2, 600); break;

            default: return;
        }

        CharacterController cc = player.GetComponent<CharacterController>();

        if (cc != null)
            cc.enabled = false;

        player.position = targetPos;

        if (cc != null)
            cc.enabled = true;

        PlayerMovement pm = player.GetComponent<PlayerMovement>();

        if (pm != null)
            pm.ResetMovement();

        SoundManager.instance.PlayTeleport();

        Debug.Log("Teleported to: " + targetPos);

        if (menuPanel != null)
            menuPanel.SetActive(false);

        if (mouseLookScript != null)
            mouseLookScript.enabled = true;

        if (playerMoveScript != null)
            playerMoveScript.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1f;
    }
}