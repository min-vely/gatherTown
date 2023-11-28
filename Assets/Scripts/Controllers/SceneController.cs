using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public InputField inputField;
    public Button joinBtn;
    public GameObject renamePanel;
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
            renamePanel.SetActive(true);

            // ���� �ð� �Ŀ� �г��� �ٽ� ��Ȱ��ȭ
            Invoke("HideRenamePanel", displayTime);
        }
    }

    private void HideEndPanel()
    {
        renamePanel.SetActive(false);
    }
}
