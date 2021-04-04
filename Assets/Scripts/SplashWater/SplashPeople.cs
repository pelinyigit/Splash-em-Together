using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashPeople : MonoBehaviour
{

    GameObject coinParticle;
    GameObject emojiParticle;

    
    bool isPeopleFall;
    [SerializeField] private List<GameObject> peoples;

    private void Awake()
    {
        coinParticle = transform.Find("CoinParticle").gameObject;
        emojiParticle = transform.Find("EmojiParticle").gameObject;
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
        //rb.AddExplosionForce(300f, transform.forward, 300f);
        rb.AddForce(transform.forward * -50f, ForceMode.Force);
        rb.AddForce(transform.up *100f, ForceMode.Force);

        coinParticle.SetActive(true);
        emojiParticle.SetActive(true);
    }
    private void OnParticleCollision()
    {
        FallenPeople();
        IncreaseCoin();
    }
   
    public void IncreaseCoin()
    {
        EventManager.OnCoinCollected?.Invoke();
    }

}
