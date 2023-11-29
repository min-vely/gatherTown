using UnityEngine;
using TMPro;

public class NPCConversation : MonoBehaviour
{
    public GameObject conversationPanel;
    public TextMeshProUGUI npcNameTxt;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾ NPC�� �浹�ϸ� ��ȭ �г��� Ȱ��ȭ
            conversationPanel.SetActive(true);

            // ��������Ʈ���� �����ͼ� NPC �̸����� ���
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && spriteRenderer.sprite != null)
            {
                npcNameTxt.text = spriteRenderer.sprite.name;
            }
            else
            {
                // ��������Ʈ�� ���� ��쿡�� �±׸� ���
                npcNameTxt.text = gameObject.tag;
            }
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
