using UnityEngine;
using TMPro;

public class DisplayNPCNames : MonoBehaviour
{
    public TextMeshProUGUI npcNamesTxt;

    void Start()
    {
        // ���� �����ϴ� ��� NPC�� �̸��� �����ͼ� Text�� ǥ��
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");

        string npcNames = "";

        foreach (GameObject npc in npcs)
        {
            npcNames += npc.name + "\n";
        }

        npcNamesTxt.text = npcNames;
    }
}
