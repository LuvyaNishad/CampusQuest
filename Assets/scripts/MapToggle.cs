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
            ToggleMap();
        }
    }

    public void ToggleMap()
    {
        worldMapUI.SetActive(!worldMapUI.activeSelf);
    }
}