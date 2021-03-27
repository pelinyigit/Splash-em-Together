using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRiderObstacle : CollectableObject
{
      private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            EventManager.OnBikeRemoved?.Invoke();
        }
    }
}
