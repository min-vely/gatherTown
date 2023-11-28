using UnityEngine;

public class PplNamePanel : MonoBehaviour
{
    public GameObject pplPanel;

    public void ActivatePanel()
    {
        pplPanel.SetActive(true);
    }

    public void DeactivatePanel()
    {
        pplPanel.SetActive(false);
    }
}
