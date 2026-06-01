using Unity.VisualScripting;
using UnityEngine;

public class OptionUI : MonoBehaviour
{
    public GameObject OptionPanelUI;

    GameObject currentOptionPanel;
    
    public void OpenOption()
    {
        if(currentOptionPanel == null)
        {
            currentOptionPanel = Instantiate(OptionPanelUI, transform);

            RectTransform rect = currentOptionPanel.GetComponent<RectTransform>();

            rect.localPosition = Vector3.zero;
            rect.localScale = Vector3.one;
        }
    }
    
}
