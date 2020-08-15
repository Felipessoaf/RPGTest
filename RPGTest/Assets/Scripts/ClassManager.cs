using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    [HideInInspector]
    public ClassesJSON ClassJson;

    public TextAsset ClassJsonFile;

    private static ClassManager _instance;

    public static ClassManager GetInstance()
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

        //read class json
        ClassJson = JsonUtility.FromJson<ClassesJSON>(ClassJsonFile.ToString());
    }
}
