using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAnimations : MonoBehaviour
{
    public List<GameObject> finishAnimations;

    public GameObject mainCamera;
    public GameObject timelineCamera;

    private void OnEnable()
    {
        EventManager.OnTimelineOpened.AddListener(TimelineOpen);
        EventManager.OnAnimationCollected.AddListener(OpenAnimation);
    }

    private void OnDisable()
    {
        EventManager.OnTimelineOpened.RemoveListener(TimelineOpen);
        EventManager.OnAnimationCollected.RemoveListener(OpenAnimation);
    }

    public void TimelineOpen()
    {
        mainCamera.SetActive(false);
        timelineCamera.SetActive(true);
    }

    public void OpenAnimation()
    {
        
        finishAnimations[finishAnimations.Count - 1].SetActive(true);
        finishAnimations.Remove(finishAnimations[finishAnimations.Count - 1]);

    }


}
