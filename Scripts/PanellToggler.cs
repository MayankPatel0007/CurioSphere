using UnityEngine;

public class PanellToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InformationPanel;

    public void togglePanel()
    {
        if (isOn)
        {
            InformationPanel.SetActive(false);
            isOn = false;
        }
        else
        {
            InformationPanel.SetActive(true);
            isOn = true;
        }
    }
}
