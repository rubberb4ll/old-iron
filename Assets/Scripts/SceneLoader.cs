using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}