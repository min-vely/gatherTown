using TMPro;
using UnityEngine;

public class DisplayCurrentTime : MonoBehaviour
{
    //public TextMeshProUGUI text_time;
    void Update()
    {
        // ���� �ð�
        System.DateTime currentTime = System.DateTime.Now;

        // �ð� ������
        string formattedTime = currentTime.ToString("HH:mm");

        GetComponent<TextMeshProUGUI>().text = formattedTime;
    }
}
