using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimizator : MonoBehaviour
{
    public int pos_x, pos_y;
    public create_game_pole create_Game_script;
    public GameObject[,] panels;
    public GameObject player;
    public GameObject plane;
    // Start is called before the first frame update
    public void Start()
    {
        plane.SetActive(false);

        panels = create_Game_script.panels;
        player.GetComponent<CharacterController>().enabled = false;
        float x = panels[0, 0].transform.position.x + 35;
        float y = panels[0, 0].transform.position.y + 0.4f;
        float z = panels[0, 0].transform.position.z + 17.5f;
        player.transform.position = new Vector3(x, y, z);
        player.GetComponent<CharacterController>().enabled = true;


        panels[pos_x, pos_y].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
