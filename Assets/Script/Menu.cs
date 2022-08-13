using UnityEngine;
using UnityEngine.SceneManagement;

internal class Menu : MonoBehaviour
{
    [SerializeField] private int index, nextIndex;
    public void Restart()
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(nextIndex);
    }
}
