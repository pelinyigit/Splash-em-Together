using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPlayer : MonoBehaviour
{


    private void OnEnable()
    {
        EventManager.OnBikeCollected.AddListener(AddBiker);
    }

    private void OnDisable()
    {
        EventManager.OnBikeCollected.RemoveListener(AddBiker);
    }


    void AddBiker()
    {
        Debug.Log("Added Biker !!");
    }
}
