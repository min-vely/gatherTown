using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    private void Awake()
    {
        string DefaultName = "";
        // PlayerPrefs���� �Է°� �ҷ�����
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");

        // �ҷ��� �Է°��� �ؽ�Ʈ�� ǥ��
        playerNameText.text = playerName;
    }
}
