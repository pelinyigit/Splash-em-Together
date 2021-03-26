using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    public static UnityEvent OnBikeCollected = new UnityEvent();

    public static UnityEvent OnLeftTilled = new UnityEvent();
    public static UnityEvent OnRightTilled = new UnityEvent();
 

}
