using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public InputField inputField;
    public Button joinBtn;
    public GameObject endPanel;
    public float displayTime = 1.0f; // ȭ�鿡 �޽����� ǥ���� �ð�

    public void Start()
    {
        joinBtn.onClick.AddListener(ValidAndSwitchScene);
    }

    public void ValidAndSwitchScene()
    {
        // �Է°�
        string inputValue = inputField.text;

        // �Է°��� 2~10������ Ȯ��
        if (inputValue.Length >= 2 && inputValue.Length <= 10)
        {
            // �Է°��� PlayerPrefs�� ����
            PlayerPrefs.SetString("PlayerName", inputValue);

            // �� ��ȯ
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            // �Է°��� ��ȿ���� �ʴٸ�
            endPanel.SetActive(true);

            // ���� �ð� �Ŀ� �г��� �ٽ� ��Ȱ��ȭ
            Invoke("HideEndPanel", displayTime);
        }
    }

    private void HideEndPanel()
    {
        endPanel.SetActive(false);
    }
}
