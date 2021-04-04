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


}
