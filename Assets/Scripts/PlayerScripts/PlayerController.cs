using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{

    enum isTilt
    {
        leftTilt = -1,
        defaultPosition = 0,
        rightTilt = 1
    }

    private Rigidbody body;

    private Vector3 startMousePosition;
    private Vector3 endMousePosition;

    public float sensitivity = .16f;
    public float clampDelta = 42f;
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private float bounds = 2.25f;

    [SerializeField]
    private float speedBounds = 2f;

    public Animator rideController;

    private isTilt tiltState = 0;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), transform.position.y, transform.position.z);

    }

    private void FixedUpdate()
    {
        body.transform.position += Vector3.forward * speed;

        if (Input.GetMouseButtonDown(0))
        {
            startMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 currentVector = startMousePosition - Input.mousePosition;
            startMousePosition = Input.mousePosition;

            if (currentVector.x < 0)
            {
                EventManager.OnRightTilt?.Invoke();
            }
            if (currentVector.x > 0)
            {
                EventManager.OnLeftTilt?.Invoke();
            }

            Debug.Log(currentVector.x);

            currentVector = new Vector3(currentVector.x, 0, 0);

            Vector3 moveForce = Vector3.ClampMagnitude(currentVector, clampDelta);


            body.AddForce(-moveForce * sensitivity - body.velocity / 5f, ForceMode.VelocityChange);

        }

        if (Input.GetMouseButtonUp(0))
        {
            rideController.SetInteger("isTilt", (int)isTilt.defaultPosition);
        }

        body.velocity.Normalize();

    }






}
