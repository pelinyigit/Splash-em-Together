using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishConstant : MonoBehaviour
{
    public ParticleSystem removeParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EventManager.OnCollisionFinish?.Invoke();
            removeParticle.Play();

        }
    }
}
