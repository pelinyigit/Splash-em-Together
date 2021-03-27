using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerTiltDirection : MonoBehaviour
{


    private void OnEnable()
    {

        EventManager.OnLeftTilt.AddListener(LeftTilt);
        EventManager.OnRightTilt.AddListener(RightTilt);

    }

    private void OnDisable()
    {

        EventManager.OnLeftTilt.RemoveListener(LeftTilt);
        EventManager.OnRightTilt.RemoveListener(RightTilt);

    }

    void LeftTilt()
    {
        transform.DOLocalRotate(new Vector3(0f, -1f, -5f * 1), 1f).SetRelative(true).OnComplete(() => transform.DOLocalRotate(new Vector3(0f, 180f, 0f), 1f));
    }

    void RightTilt()
    {
        transform.DOLocalRotate(new Vector3(0f, 1f, 5f * 1), 1f).SetRelative(true).OnComplete(() => transform.DOLocalRotate(new Vector3(0f, 180f, 0f), 1f));
    }




}
