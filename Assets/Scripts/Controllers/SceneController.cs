using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public InputField inputField;
    public Button joinBtn;
    public GameObject renamePanel;
    public float displayTime = 1.0f; // 화면에 메시지를 표시할 시간

    public void Start()
    {
        joinBtn.onClick.AddListener(ValidAndSwitchScene);
    }

    public void ValidAndSwitchScene()
    {
        // 입력값
        string inputValue = inputField.text;

        // 입력값이 2~10자인지 확인
        if (inputValue.Length >= 2 && inputValue.Length <= 10)
        {
            // 입력값을 PlayerPrefs에 저장
            PlayerPrefs.SetString("PlayerName", inputValue);

            // 씬 전환
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            // 입력값이 유효하지 않다면
            renamePanel.SetActive(true);

            // 일정 시간 후에 패널을 다시 비활성화
            Invoke("HideRenamePanel", displayTime);
        }
    }

    private void HideEndPanel()
    {
        renamePanel.SetActive(false);
    }
}
