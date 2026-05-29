using UnityEngine;

public class MapToggle : MonoBehaviour
{
    public GameObject worldMapUI;

    void Start()
    {
        worldMapUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            worldMapUI.SetActive(!worldMapUI.activeSelf);
        }
    }
}