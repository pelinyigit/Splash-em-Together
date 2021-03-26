using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRightTill : MonoBehaviour
{

    private void OnEnable()
    {

        EventManager.OnRightTilled.AddListener(RightTill);

    }

    private void OnDisable()
    {

        EventManager.OnRightTilled.RemoveListener(RightTill);

    }

    void RightTill()
    {
        transform.DOLocalRotate(new Vector3(0f, 0f, 10f * 1), 1f).SetRelative(true).OnComplete(() => transform.DOLocalRotate(new Vector3(0f, 180f, 0f), 1f));
    }
}
