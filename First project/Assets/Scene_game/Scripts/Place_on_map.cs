using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_on_map : MonoBehaviour
{
    private List<GameObject> rows;
    public Optimizator optimizator;
    public GameObject player;
    public GameObject panel;
    public int x_pos, y_pos;
    public GameObject[,] panels = new GameObject[10, 10];
    public GameObject panel_old;
    public GameObject camera;
    private float x;
    private float y;
    private float z;

    void Start()
    {
        rows = optimizator.rows;

        for (int y = 0; y < 10; y++)
            for (int x = 0; x < 10; x++)
                panels[x, y] = rows[y].GetComponent<Rows_panel>().panels[x];

        panel = panels[x_pos, y_pos];
        panel_old = panel;

        player.GetComponent<CharacterController>().enabled = false;
        x = panel.transform.position.x + 35;
        y = panel.transform.position.y - 2.1f;
        z = panel.transform.position.z + 17.5f;
        player.transform.position = new Vector3(x, y, z);
        player.GetComponent<CharacterController>().enabled = true;

        x = panel.transform.position.x + 35;
        y = panel.transform.position.y + 26;
        z = panel.transform.position.z - 0.3f;
        camera.transform.position = new Vector3(x,y,z);
        panel_old = panel;
    }

    // Update is called once per frame
    void Update()
    {
        panel = panels[x_pos, y_pos];
        if (panel != panel_old)
        {
            x = panel.transform.position.x + 35;
            y = panel.transform.position.y + 26;
            z = panel.transform.position.z - 0.3f;
            camera.transform.position = new Vector3(x, y, z);

            panel.SetActive(true);
            panel_old.SetActive(false);
            panel_old = panel;
        }
    }
}
