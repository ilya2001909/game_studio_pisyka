using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Camera cam;

    void Awake()
    {
        instance = this; 
    }
}
