using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Cargando escena: " + sceneName);
        
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("La escena " + sceneName + " no está en Build Settings o el nombre es incorrecto.");
        }
    }
}
