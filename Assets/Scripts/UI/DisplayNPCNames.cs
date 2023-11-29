using UnityEngine;
using TMPro;

public class DisplayNPCNames : MonoBehaviour
{
    public TextMeshProUGUI npcNamesTxt;

    void Start()
    {
        // 씬에 존재하는 모든 NPC의 이름을 가져와서 Text로 표시
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");

        string npcNames = "";

        foreach (GameObject npc in npcs)
        {
            npcNames += npc.name + "\n";
        }

        npcNamesTxt.text = npcNames;
    }
}
