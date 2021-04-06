using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public ResourcesCoin resourcesCoin;

    public int collectedCoin;

    public static CoinCollect instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        EventManager.OnCoinCollected.AddListener(CoinCollected);
        EventManager.OnCoinUnclaimed.AddListener(CoinUnclaimed);
    }

    private void OnDisable()
    {
        EventManager.OnCoinCollected.RemoveListener(CoinCollected);
        EventManager.OnCoinUnclaimed.RemoveListener(CoinUnclaimed);
    }

    public void CoinCollected()
    {
        int i = 0;
        i += Random.Range(0, 2);
        resourcesCoin.coinAmount += i;
        collectedCoin += i;

    }

    public void CoinUnclaimed()
    {
        resourcesCoin.coinAmount -= collectedCoin;
        collectedCoin = 0;
    }
}
