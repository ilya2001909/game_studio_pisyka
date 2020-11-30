using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtsSistem : MonoBehaviour
{
    public int health;

    public Sprite fullLive;
    public Sprite emptyLive;
    public List<Sprite> helf_images = new List<Sprite>(3);


    // Start is called before the first frame update
    void Start()
    {
        helf_images[0] = fullLive;
        helf_images[1] = fullLive;
        helf_images[2] = fullLive;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
