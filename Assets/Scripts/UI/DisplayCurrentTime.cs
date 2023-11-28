using TMPro;
using UnityEngine;

public class DisplayCurrentTime : MonoBehaviour
{
    //public TextMeshProUGUI text_time;
    void Update()
    {
        // 현재 시간
        System.DateTime currentTime = System.DateTime.Now;

        // 시간 포맷팅
        string formattedTime = currentTime.ToString("HH:mm");

        GetComponent<TextMeshProUGUI>().text = formattedTime;
    }
}
