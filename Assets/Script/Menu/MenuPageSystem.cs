using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPageSystem : MonoBehaviour
{
    public void SettingButton()
    {

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        SceneManager.UnloadSceneAsync("MenuScene");
    }
}
