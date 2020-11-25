using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtsSistem : MonoBehaviour
{
    public int health;

    public List<Image> helf_images = new List<Image>(6);

    public Sprite fullLive;
    public Sprite emptyLive;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < helf_images.Count; i++)
        {
            if (i<health)
            {
                helf_images[i].sprite = fullLive;
            }
            else
            {
                helf_images[i].sprite = emptyLive;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
