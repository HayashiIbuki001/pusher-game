using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneChanger : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
        Time.timeScale = 0f;
    }
}
