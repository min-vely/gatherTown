using UnityEngine;
using TMPro;

public class NPCConversation : MonoBehaviour
{
    public GameObject conversationPanel;
    public TextMeshProUGUI npcNameTxt;

    public string npcName = "Jimin"; // NPC �̸�

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾ NPC�� �浹�ϸ� ��ȭ �г��� Ȱ��ȭ
            conversationPanel.SetActive(true);

            npcNameTxt.text = npcName;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾ NPC �ݶ��̴� ������ ����� ��ȭ �г��� ��Ȱ��ȭ
            conversationPanel.SetActive(false);
        }
    }
}
