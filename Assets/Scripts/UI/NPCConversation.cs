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
            // 플레이어가 NPC랑 충돌하면 대화 패널을 활성화
            conversationPanel.SetActive(true);

            // 스프라이트명을 가져와서 NPC 이름으로 사용
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && spriteRenderer.sprite != null)
            {
                npcNameTxt.text = spriteRenderer.sprite.name;
            }
            else
            {
                // 스프라이트가 없는 경우에는 태그를 사용
                npcNameTxt.text = gameObject.tag;
            }
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
