using UnityEngine;
using UnityEngine.UI;

public class MainTabManager : MonoBehaviour
{
    public GameObject actionPanel;
    public GameObject questPanel;

    public Button btnAction;
    public Button btnQuest;

    Color normalColor = Color.white;
    Color activeColor = new Color(0.35f, 0.55f, 0.35f);

    void Start()
    {
        ShowAction();
    }

    public void ShowAction()
    {
        actionPanel.SetActive(true);
        questPanel.SetActive(false);
        SetActiveButton(btnAction, btnQuest);
    }

    public void ShowQuest()
    {
        actionPanel.SetActive(false);
        questPanel.SetActive(true);
        SetActiveButton(btnQuest, btnAction);
    }

    void SetActiveButton(Button active, Button inactive)
    {
        ColorBlock c1 = active.colors;
        c1.normalColor = activeColor;
        c1.selectedColor = activeColor;
        c1.highlightedColor = activeColor;
        c1.pressedColor = Color.green;
        active.colors = c1;

        ColorBlock c2 = inactive.colors;
        c2.normalColor = normalColor;
        c2.selectedColor = normalColor;
        c2.highlightedColor = normalColor;
        c2.pressedColor = Color.green;
        inactive.colors = c2;
    }
}