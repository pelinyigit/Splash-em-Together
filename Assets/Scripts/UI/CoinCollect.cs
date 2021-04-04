using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public ResourcesCoin resourcesCoin;

    private void OnEnable()
    {
        EventManager.OnCoinCollected.AddListener(CoinCollected);   
    }

    private void OnDisable()
    {
        EventManager.OnCoinCollected.RemoveListener(CoinCollected);
    }

    public void CoinCollected()
    {
        resourcesCoin.coinAmount += Random.Range(0,2);
    }
}
