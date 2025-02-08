using UnityEngine;
using UnityEngine.EventSystems;

public class OpenTextLink : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string url = "https://blog.febucci.com/2018/10/unity-ui-tutorial/";

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(url);
    }
}
