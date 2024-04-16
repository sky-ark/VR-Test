using UnityEngine;

public class BallThrower : MonoBehaviour
{
    private bool isGrabbed = false;
    private Vector3 grabPosition;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnGrab()
    {
        isGrabbed = true;
        grabPosition = transform.position;
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void OnRelease()
    {
        isGrabbed = false;
        rb.useGravity = true;
        rb.AddForce((transform.position ) * 10f, ForceMode.Impulse);
    }
}