using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPlayer : MonoBehaviour
{
    public List<GameObject> bikers;
    public GameObject biker;
    public Transform bikerPosition;
    private void OnEnable()
    {
        EventManager.OnBikeCollected.AddListener(AddBiker);
        EventManager.OnBikeRemoved.AddListener(RemoveBiker);
    }

    private void OnDisable()
    {
        EventManager.OnBikeCollected.RemoveListener(AddBiker);
        EventManager.OnBikeRemoved.RemoveListener(RemoveBiker);
    }

    void AddBiker()
    {
        GameObject newBiker = (GameObject)Instantiate(biker, bikerPosition.position + new Vector3(0, 0, .80f), bikerPosition.rotation);
        newBiker.transform.SetParent(gameObject.transform);
        bikerPosition = newBiker.transform;
        bikers.Add(newBiker);
    }
    void RemoveBiker()
    {
        if (bikers.Count - 1 >= 1)
        {
            Destroy(bikers[bikers.Count - 1]);
            bikers.Remove(bikers[bikers.Count - 1]);
            bikerPosition = bikers[bikers.Count - 1].transform;
        }
        else
        {
            EventManager.OnGameOver?.Invoke();
            //TO DO: crash particle and stop player
        }
        
    }
}
