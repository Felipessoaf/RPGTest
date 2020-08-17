using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void OnStart();
    public static OnStart StartDelegate;

    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;            
        }
    }
}
