using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text coinText;

    public ResourcesCoin resourcesCoin;

    private void Update()
    {
        UpdateResources();
    }

    private void UpdateResources()
    {
        coinText.text = resourcesCoin.coinAmount.ToString();
    }
}
