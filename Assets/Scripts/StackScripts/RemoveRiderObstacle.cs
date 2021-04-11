using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRiderObstacle : CollectableObject
{
    public ParticleSystem removeParticle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            EventManager.OnBikeRemoved?.Invoke();
            removeParticle.Play();

        }
    }
}
