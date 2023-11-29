using UnityEngine;
using TMPro;

public class NPCConversation : MonoBehaviour
{
    public GameObject conversationPanel;
    public TextMeshProUGUI npcNameTxt;

    public string npcName = "Jimin"; // NPC 이름

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어가 NPC랑 충돌하면 대화 패널을 활성화
            conversationPanel.SetActive(true);

            npcNameTxt.text = npcName;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어가 NPC 콜라이더 범위를 벗어나면 대화 패널을 비활성화
            conversationPanel.SetActive(false);
        }
    }
}
