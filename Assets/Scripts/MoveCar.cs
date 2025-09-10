using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed = 1000.0f;
    private Rigidbody carRb;
    private bool isOnGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnGround)
        {
            carRb.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Acceleration);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
