using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    private void Awake()
    {
        // PlayerPrefs에서 입력값 불러오기
        string playerName = PlayerPrefs.GetString("PlayerName");

        // 불러온 입력값을 텍스트로 표시
        playerNameText.text = playerName;
    }
}
