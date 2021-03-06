using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        DefaultGameState,
        StartGameState,
        PauseGameState,
        GameOverState,
        FinishGameState
    }

    public GameState currentState;

    public static GameManager instance;

    private GameObject canvas;

    private GameObject defaultCanvas;
    private GameObject inGameCanvas;
    private GameObject pauseCanvas;
    private GameObject failCanvas;
    private GameObject successCanvas;
    

    private void OnEnable()
    {
        EventManager.OnGameStarted.AddListener(StartGame);
        EventManager.OnGamePaused.AddListener(PauseGame);
        EventManager.OnGameOver.AddListener(GameOver);
        EventManager.OnFinished.AddListener(FinishGame);      
    }

    private void OnDisable()
    {
        EventManager.OnGameStarted.RemoveListener(StartGame);
        EventManager.OnGamePaused.RemoveListener(PauseGame);
        EventManager.OnGameOver.RemoveListener(GameOver);
        EventManager.OnFinished.RemoveListener(FinishGame);
    }

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

        canvas = GameObject.Find("Canvas");
        defaultCanvas = FindObject(canvas, "DefaultCanvas");
        inGameCanvas = FindObject(canvas, "InGameCanvas");
        pauseCanvas = FindObject(canvas, "PauseCanvas");
        failCanvas = FindObject(canvas, "FailCanvas");
        successCanvas = FindObject(canvas, "SuccessCanvas");
    }

    private void Update()
    {
        switch (currentState)
        {
            case GameState.DefaultGameState:
                inGameCanvas.SetActive(true);
                defaultCanvas.SetActive(true);
                pauseCanvas.SetActive(false);
                failCanvas.SetActive(false);
                successCanvas.SetActive(false);

                break;
            case GameState.StartGameState:
                inGameCanvas.SetActive(true);
                defaultCanvas.SetActive(false);
                pauseCanvas.SetActive(false);
                failCanvas.SetActive(false);
                successCanvas.SetActive(false);
                break;
            case GameState.PauseGameState:
                inGameCanvas.SetActive(true);
                defaultCanvas.SetActive(false);
                pauseCanvas.SetActive(true);
                failCanvas.SetActive(false);
                successCanvas.SetActive(false);
                break;
            case GameState.GameOverState:
                inGameCanvas.SetActive(true);
                defaultCanvas.SetActive(false);
                pauseCanvas.SetActive(false);
                failCanvas.SetActive(true);
                successCanvas.SetActive(false);
                break;
            case GameState.FinishGameState:
                inGameCanvas.SetActive(true);
                defaultCanvas.SetActive(false);
                pauseCanvas.SetActive(false);
                failCanvas.SetActive(false);
                successCanvas.SetActive(true);
                break;
        }
    }

    public void StartGame()
    {
        currentState = GameState.StartGameState;
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        currentState = GameState.PauseGameState;   
        Time.timeScale = 0;
    }
    public void GameOver()
    {
        currentState = GameState.GameOverState;
    }
    public void FinishGame()
    {
        currentState = GameState.FinishGameState;
    }


    public  GameObject FindObject( GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }


}
