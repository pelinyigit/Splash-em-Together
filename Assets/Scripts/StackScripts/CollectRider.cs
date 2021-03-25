using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRider : CollectableObject
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            EventManager.OnBikeCollected?.Invoke();
            base.DisposeObject();
          
        }
    }


}
