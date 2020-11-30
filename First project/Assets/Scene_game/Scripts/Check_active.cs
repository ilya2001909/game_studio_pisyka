using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_active : MonoBehaviour
{
    public bool IsActive;
    public GameObject player;
    public GameObject pos_cam;
    public GameObject cam;
    public ParticleSystem[] particles;


    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {        
        
    }   

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //cam = GameObject.Find("Main Camera");
            cam = GameController.instance.cam.gameObject;
            player = col.gameObject;
            IsActive = true;
            cam.transform.position = pos_cam.transform.position;
            cam.transform.rotation = pos_cam.transform.rotation;
            foreach (ParticleSystem p in particles)
            {
                p.gameObject.SetActive(true);
            }
        }
    }


}
