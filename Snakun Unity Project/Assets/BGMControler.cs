using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMControler : MonoBehaviour
{
    public AudioSource BGM_menu;
    public AudioSource BGM_game;

    private string beforeScene = "Title";

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(BGM_menu.gameObject);
        DontDestroyOnLoad(BGM_game.gameObject);

        SceneManager.activeSceneChanged += OnActiveSceneChanged;

    }

    void OnActiveSceneChanged (Scene prevScene, Scene nextScene)
    {
        if (beforeScene == "Title" && nextScene.name == null)
        {
            BGM_menu.Play();
        }
        if (beforeScene == "Title" && nextScene.name == "GAME")
        {
            BGM_menu.Stop();
            BGM_game.Play();
        }

        if (beforeScene == "asobikata" && nextScene.name == "GAME")
        {
            BGM_menu.Stop();
            BGM_game.Play();
        }

        if (beforeScene == "GAME" && nextScene.name == "Result")
        {
            //Title_BGM.Stop();
            BGM_game.Stop();
        }

        if (beforeScene == "Result" && nextScene.name == "Title")
        {
            BGM_menu.Play();
            //Game_BGM.Stop();
        }

        beforeScene = nextScene.name;
    }

}
