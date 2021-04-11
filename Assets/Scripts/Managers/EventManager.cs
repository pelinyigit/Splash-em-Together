using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    public static UnityEvent OnBikeCollected = new UnityEvent();
    public static UnityEvent OnBikeRemoved = new UnityEvent();

    public static UnityEvent OnLeftTilt = new UnityEvent();
    public static UnityEvent OnRightTilt = new UnityEvent();

    public static UnityEvent OnCoinCollected = new UnityEvent();
    public static UnityEvent OnCoinUnclaimed = new UnityEvent();

    public static UnityEvent OnFinished = new UnityEvent();
    public static UnityEvent OnGameOver = new UnityEvent();
    public static UnityEvent OnGameStarted = new UnityEvent();
    public static UnityEvent OnGamePaused = new UnityEvent();

    public static UnityEvent OnCurrentLevel = new UnityEvent();
    public static UnityEvent OnNextLevel = new UnityEvent();

    public static UnityEvent OnAnimationCollected = new UnityEvent();
    public static UnityEvent OnCollisionFinish = new UnityEvent();

    public static UnityEvent OnTimelineOpened = new UnityEvent();

}
