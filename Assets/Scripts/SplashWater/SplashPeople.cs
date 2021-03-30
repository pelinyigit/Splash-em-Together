using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashPeople : MonoBehaviour
{
    bool isPeopleFall;
    [SerializeField] private List<GameObject> peoples;
    private void Start()
    {
      
    }
    private void OnParticleTrigger()
    {
        //TO DO: Ragdoll NPC's, People Multiplier Score ++(Random)
        
    }
    private void FallenPeople()
    {
        if (isPeopleFall) return;
        GetComponentInChildren<Animator>().SetBool("isDead",true);
        isPeopleFall = true;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(300f, transform.forward, 300f);
    }
    private void OnParticleCollision()
    {
        FallenPeople();
        Debug.Log("Fallen People");
    }

}
