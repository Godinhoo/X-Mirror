using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    protected override void Awake()
    {
        // Check for duplicates of this Singleton
        base.Awake();

        //Make this Manager persistent across all scenes
        DontDestroyOnLoad(gameObject);
    }


    public void GoToLevel(int level)
    {
        switch (level)
        {
            case 0:
                SceneManager.LoadScene("Level1");
                break;
            case 1:
                SceneManager.LoadScene("Level2");
                break;
        }
    }

    public void GoToSettings()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
