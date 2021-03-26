using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerLeftTill : MonoBehaviour
{


    private void OnEnable()
    {

        EventManager.OnLeftTilled.AddListener(LeftTill);
       
    }

    private void OnDisable()
    {

        EventManager.OnLeftTilled.RemoveListener(LeftTill);
       
    }

    void LeftTill()
    {
        transform.DOLocalRotate(new Vector3(0f, 0f, -10f * 1), 1f).SetRelative(true).OnComplete(() => transform.DOLocalRotate(new Vector3(0f, 180f, 0f), 1f));
    }





}
