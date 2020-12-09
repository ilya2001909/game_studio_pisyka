using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_script : MonoBehaviour
{
    public GameObject player;
    public GameObject panels;
    public GameObject[,] panels_mass = new GameObject[10,10];
    public List<GameObject> enemys = new List<GameObject>();
    private List<GameObject> enemys_place = new List<GameObject>(200);


    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                panels_mass[i, j] = panels.GetComponent<Optimizator>().rows[i].GetComponent<Rows_panel>().panels[j];
                enemys_place.Add(panels_mass[i, j].GetComponent<Spawn_enemys>().spawn_1);
                enemys_place.Add(panels_mass[i, j].GetComponent<Spawn_enemys>().spawn_2);
            }
        }
        for (int i = 0; i < 200; i++)
        {
            System.Random random = new System.Random();
            int index = random.Next(0, 5);
            create_enemy(enemys[index], enemys_place[i].transform);
        }
    }

    public void create_enemy(GameObject enemy, Transform transform)
    {
        GameObject new_enemy = Instantiate(enemy, transform.position, transform.rotation);
        new_enemy.name = enemy.name;
        switch (new_enemy.name)
        {
            case "Sobaka":
                new_enemy.GetComponent<Alien_walk>().target = player;
                break;
            case "Acula":
                new_enemy.GetComponent<Alien_Walk_Akula>().target = player;
                break;
            case "SpaceGolem":
                new_enemy.GetComponent<Alien_walk_space_golem>().target = player;
                break;
            case "Spider":
                new_enemy.GetComponent<Alien_walk_pauk>().target = player;
                break;
            case "Tarakan":
                new_enemy.GetComponent<Alien_walk_tarakan>().target = player;
                break;
        }
    }
}

