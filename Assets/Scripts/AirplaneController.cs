using UnityEngine;
using UnityEngine.InputSystem;

// Minimal airplane used in place of the previous lab. Press Space to take off:
// the wing plays the ThrottleUp animation and the plane flies toward the Wall.
[RequireComponent(typeof(Rigidbody))]
public class AirplaneController : MonoBehaviour
{
    public Animator wingAnimator;
    public float forwardSpeed = 12f;
    public float climbSpeed = 1.5f;

    public bool hasTakenOff { get; private set; }

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (wingAnimator == null)
            wingAnimator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (!hasTakenOff && Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
            TakeOff();
    }

    private void FixedUpdate()
    {
        if (hasTakenOff)
            rb.linearVelocity = new Vector3(0f, climbSpeed, forwardSpeed);
    }

    public void TakeOff()
    {
        if (hasTakenOff) return;

        hasTakenOff = true;
        if (wingAnimator != null)
            wingAnimator.SetTrigger("takeoff");
        rb.linearVelocity = new Vector3(0f, climbSpeed, forwardSpeed);
    }
}
