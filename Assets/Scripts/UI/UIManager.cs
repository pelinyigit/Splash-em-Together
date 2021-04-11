using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text coinText;
    public Text rewardText;
    public ResourcesCoin resourcesCoin;

    private GameObject LevelProgressTextObject;
    private Text levelProgressText;



    private void Awake()
    {
        LevelProgressTextObject = GameObject.Find("LevelProgressText");
        levelProgressText = LevelProgressTextObject.GetComponent<Text>();
    }

    private void Update()
    {
        UpdateResources();
        levelProgressText.text = "LEVEL " + LevelManager.instance.level;
    }

    private void UpdateResources()
    {
        coinText.text = resourcesCoin.coinAmount.ToString();
        rewardText.text = CoinCollect.instance.collectedCoin.ToString();
    }

    public void LevelFailSkip()
    {
        //TO DO: Ad Watched
        EventManager.OnNextLevel?.Invoke();
        EventManager.OnCoinUnclaimed?.Invoke();
    }

    public void LevelFailRestart()
    {
        EventManager.OnCurrentLevel?.Invoke();
        EventManager.OnCoinUnclaimed?.Invoke();
    }

    public void LevelSuccessClaim()
    {
        EventManager.OnNextLevel?.Invoke();
    }

    public void LevelSuccessNext()
    {
        EventManager.OnCoinUnclaimed?.Invoke();
        EventManager.OnNextLevel?.Invoke();  
    }

    public void OpenPause()
    {
        EventManager.OnGamePaused?.Invoke();
    }
    public void ClosePause()
    {
        EventManager.OnGameStarted?.Invoke();
    }
}
