using UnityEngine;
using UnityEngine.EventSystems;

public class UISelect : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(target);
    }
}
