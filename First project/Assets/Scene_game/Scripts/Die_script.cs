using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Die_script : MonoBehaviour
{
    public Slider sliderHP;
    public GameObject player;
    public GameObject text_u_die;
    public GameObject Live;
    public GameObject button;

    // Update is called once per frame
    void Update()
    {
        if (sliderHP.value == 0)
        {
            player.SetActive(false);
            Live.SetActive(false);
            text_u_die.SetActive(true);
            button.SetActive(true);
            sliderHP.value = 0.0001f;
        }
    }

    public void if_u_die()
    {        
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
