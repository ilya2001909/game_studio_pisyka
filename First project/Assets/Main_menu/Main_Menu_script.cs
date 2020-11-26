using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_script : MonoBehaviour
{
    public bool play;
    public bool levels;
    public bool settings;
    public bool exit;
    public bool music=true;
    public Button music_button;
    public AudioSource music_main_menu;
    public AudioSource music_effects;
    public Sprite music_on;
    public Sprite music_off;

    void Start()
    {
        music = false;
        music_button.image.sprite = music_off;
        music_main_menu.mute = true;
        music_effects.mute = true;
    }

    void Update()
    {
        if (play)
        {
            Debug.Log("play");
            play = false;
            SceneManager.LoadScene("Scene_Game", LoadSceneMode.Single);
        }
        if (levels)
        {
            Debug.Log("levels");
            levels = false;
        }
        if (settings)
        {
            Debug.Log("settings");
            settings = false;
        }
        if (exit)
        {
            Application.Unload();
            Debug.Log("Exit");
            exit = false;
        }
    }

    public void Click_play()
    {
        play = true;
    }
    public void Click_levels()
    {
        levels = true;
    }
    public void Click_settings()
    {
        settings = true;
    }
    public void Click_exit()
    {
        exit = true;
    }
    public void Click_music()
    {
        if (music)
        {
            music = false;
            music_button.image.sprite = music_off;
            music_main_menu.mute = true;
            music_effects.mute = true;
        }
        else
        {
            music = true;
            music_button.image.sprite = music_on;
            music_main_menu.mute = false;
            music_effects.mute = false;
        }
    }
}
