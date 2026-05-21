using UnityEngine;
using TMPro;

public class DirectionIndicator : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Transform player;
    public RectTransform arrowUI;
    public TMP_Text distanceText;

    Camera cam;

    Vector3[] targets =
    {
        new Vector3(611, 2, 553),   // Main Gate
        new Vector3(680, 2, 450),   // Harkesh Gate
        new Vector3(379, 2, 374),   // Lecture Hall
        new Vector3(680, 2, 530),   // Sports Block
        new Vector3(236, 2, 411),    // Old Acad
        new Vector3(150f,0f,90f),    // Old Boys Hostel
        new Vector3(180f,0f,110f),   // New Boys Hostel
        new Vector3(210f,0f,130f),   // Boys Hostel
        new Vector3(240f,0f,150f),   // Mess
        new Vector3(270f,0f,170f),   // Library
        new Vector3(300f,0f,190f)    // RnD
    };

    void Start()
    {
        cam = Camera.main;
        arrowUI.gameObject.SetActive(false);
        distanceText.text = "";
    }

    void Update()
    {
        int index = dropdown.value;

        if (index <= 0 || index > targets.Length)
        {
            arrowUI.gameObject.SetActive(false);
            distanceText.text = "";
            return;
        }

        Vector3 target = targets[index - 1];

        Vector3 dir = target - player.position;
        dir.y = 0f;

        float distance = dir.magnitude;

        arrowUI.gameObject.SetActive(true);
        distanceText.text = Mathf.Round(distance) + " m";

        Vector3 forward = player.forward;
        forward.y = 0f;

        float angle = Vector3.SignedAngle(forward, dir, Vector3.up);

        arrowUI.localRotation = Quaternion.Euler(0, 0, -angle);

        if (distance < 5f)
        {
            distanceText.text = "Arrived";
        }
    }
}