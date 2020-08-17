using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharVisual : MonoBehaviour
{
    public Material[] ClassMaterials;

    public MeshRenderer Mesh;

    private void OnEnable()
    {
        GameManager.StartDelegate += ChangeVisual;
    }

    private void OnDisable()
    {
        GameManager.StartDelegate -= ChangeVisual;
    }

    private void ChangeVisual()
    {
        int classId = PlayerPrefs.GetInt("classId", 0);

        Mesh.material = ClassMaterials[classId];
    }
}
