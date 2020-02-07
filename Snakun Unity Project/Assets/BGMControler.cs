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
        if (!BGM_game.isPlaying && !BGM_menu.isPlaying)
        {
            BGM_menu.Play();
        }
        else if (BGM_menu.isPlaying)
        {
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
        }
        else if (BGM_game.isPlaying)
        {
            if (beforeScene == "GAME" && nextScene.name == "Result")
            {
                BGM_game.Stop();
            }
        }
        /*if (beforeScene == "Title" && nextScene.name == "GAME")
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
            BGM_game.Stop();
        }

        if (beforeScene == "Result" && nextScene.name == "Title")
        {
            BGM_menu.Play();
        }

        if (!BGM_menu.isPlaying && beforeScene == "Title" && !BGM_game.isPlaying)
        {
            BGM_menu.Play();
        }*/
        beforeScene = nextScene.name;
    }

}
