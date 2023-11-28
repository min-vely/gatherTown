using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    private void Awake()
    {
        // PlayerPrefs���� �Է°� �ҷ�����
        string playerName = PlayerPrefs.GetString("PlayerName");

        // �ҷ��� �Է°��� �ؽ�Ʈ�� ǥ��
        playerNameText.text = playerName;
    }
}
