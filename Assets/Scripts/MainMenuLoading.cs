using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuLoading : MonoBehaviour
{
    [SerializeField]
    private Image progressBar;

    private void Start()
    {
        
        StartCoroutine(LoadAsyncOperation());
       
    }

    IEnumerator LoadAsyncOperation()
    {
        if (PlayerPrefs.GetInt("isFirst") == 0)
        {
            AsyncOperation gameLevel0 = SceneManager.LoadSceneAsync(1);
            PlayerPrefs.SetInt("isFirst", 1);
            PlayerPrefs.SetInt("C_Level", 1);

            while (gameLevel0.progress < 1)
            {
                progressBar.fillAmount = gameLevel0.progress;
                yield return new WaitForEndOfFrame();
            }
        }
        else
        {
            AsyncOperation gameLevel = SceneManager.LoadSceneAsync(PlayerPrefs.GetInt("C_Level"));

            while (gameLevel.progress<1)
            {
                progressBar.fillAmount = gameLevel.progress;
                yield return new WaitForEndOfFrame();
            }
        }
       

        
    }
}
