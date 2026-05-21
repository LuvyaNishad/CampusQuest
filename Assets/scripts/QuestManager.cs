using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public TMP_Text quest1;
    public TMP_Text quest2;
    public TMP_Text quest3;

    public Slider xpBar;
    public TMP_Text xpText;

    int xp = 0;
    int maxXP = 30;

    bool done1 = false;
    bool done2 = false;
    bool done3 = false;

    void Start()
    {
        xpBar.maxValue = maxXP;
        xpBar.value = xp;
        xpText.text = "XP: 0 / 30";
    }

    public void CompleteQuest(int questNo)
    {
        if (questNo == 1 && !done1)
        {
            done1 = true;
            quest1.text = "✔ Reach LHC";
            quest1.color = Color.green;
            AddXP(10);
            SoundManager.instance.PlayXP();
        }

        if (questNo == 2 && !done2)
        {
            done2 = true;
            quest2.text = "✔ Reach Main Gate";
            quest2.color = Color.green;
            AddXP(10);
            SoundManager.instance.PlayXP();
        }

        if (questNo == 3 && !done3)
        {
            done3 = true;
            quest3.text = "✔ Reach Sports Block";
            quest3.color = Color.green;
            AddXP(10);
            SoundManager.instance.PlayXP();
        }
    }

    void AddXP(int amount)
    {
        xp += amount;
        xpBar.value = xp;
        xpText.text = "XP: " + xp + " / 30";
    }
}