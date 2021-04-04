using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashablePeople : MonoBehaviour
{
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            foreach(Transform child in other.gameObject.transform)
            {
                if(child.tag == "SplashParticle")
                {
                    if (child != null)
                    {
                        child.gameObject.SetActive(true);
                    }
                }

                if(child.tag == "Trail")
                {
                    if (child != null)
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (Transform child in other.gameObject.transform)
            {
                if (child.tag == "SplashParticle")
                {
                    if (child != null)
                    {
                        child.gameObject.SetActive(false);
                    }
                }

                if (child.tag == "Trail")
                {
                    if (child != null)
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    

}
