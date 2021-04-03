using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [Range(-1f,1f)]public float bendX = 0.1f;
    [Range(-1f, 1f)] public float bendY = 0.1f;
    public Material[] materials;

    void Start()
    {
        
    }

   
    void Update()
    {
        foreach(var m in materials)
        {
            m.SetFloat(Shader.PropertyToID("X_Axis"),bendX);
            m.SetFloat(Shader.PropertyToID("Y_Axis"), bendY);
        }
    }
}
