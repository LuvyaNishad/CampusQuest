using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public int questNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<QuestManager>().CompleteQuest(questNumber);
            gameObject.SetActive(false);
        }
    }
}