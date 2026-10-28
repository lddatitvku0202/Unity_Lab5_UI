using UnityEngine;
using UnityEngine.SceneManagement;

// Small helper for buttons that only need to load a scene by name (e.g. "Back" in _Scene_1).
public class SceneLoader : MonoBehaviour
{
    public void Load(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
