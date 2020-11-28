using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_game_pole : MonoBehaviour
{

    public int kol_room_x, kol_room_y;
    public GameObject[,] panels; 

    public GameObject pole_zon;
    public float x_change = 70;
    public float z_change = 34.5f;
    private float x_start_pos;
    private float y_start_pos;
    private float z_start_pos;

    public Pose start_create_position;

    public GameObject optimizator;
   
    void Start()
    {

        panels = new GameObject[kol_room_x, kol_room_y];
        x_start_pos = start_create_position.position.x;
        y_start_pos = start_create_position.position.y;
        z_start_pos = start_create_position.position.z;
        float x = x_start_pos;
        float y = y_start_pos;
        float z = z_start_pos;

        for (int i1 = 0; i1 < kol_room_y; i1++)
        {
            for (int i2 = 0; i2 < kol_room_x; i2++)
            {
                Vector3 pos = new Vector3(x, y, z);

                Quaternion qua = transform.rotation;

                panels[i1, i2] = Instantiate(pole_zon, pos, qua);

                panels[i1, i2].name = pole_zon.name + " - (" + (i2).ToString() + ";" + (i1).ToString() + ")";

                ////////////////////////////////////////////////////////////////////////////////////////////////
                /// Отключение порталов если панель крайняя
                ////////////////////////////////////////////////////////////////////////////////////////////////
                
                if (i1 == 0)
                {
                    panels[i1, i2].GetComponent<Teleports>().teleport_Botton.SetActive(false);
                }
                if (i2 == 0)
                {
                    panels[i1, i2].GetComponent<Teleports>().teleport_Left.SetActive(false);
                }
                if (i1 == kol_room_x-1)
                {
                    panels[i1, i2].GetComponent<Teleports>().teleport_Top.SetActive(false);
                }
                if (i2 == kol_room_y-1)
                {
                    panels[i1, i2].GetComponent<Teleports>().teleport_Right.SetActive(false);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////
               
                panels[i1, i2].SetActive(false); //Заранее выключаю все порталы

                ParticleSystem[] ps = panels[i1, i2].GetComponentsInChildren<ParticleSystem>();
                foreach (ParticleSystem p in ps)
                {
                    p.gameObject.SetActive(false);
                }
                panels[i1, i2].GetComponent<Check_active>().particles = ps;

                x = x + x_change;
            }
            x = x_start_pos;
            z = z + z_change;
        }


        optimizator.SetActive(true);                        //  Включаю оптимизатор чтобы он заранее не получил все данные
        optimizator.GetComponent<Optimizator>().Start();    //  Включаю старт (его скрипта)
    }


}
