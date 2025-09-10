using UnityEngine;

public abstract class Car : MonoBehaviour
{
    //ENCAPSULATION
    public virtual float Speed { get; protected set; }
    public virtual float Mass  { get; protected set; }
    private float speedMultiplier = 1000.0f;
    private Rigidbody carRb;
    private bool isOnGround;
    
    protected void Start()
    {
        carRb = GetComponent<Rigidbody>();
        carRb.mass = Mass;
    }

    // Update is called once per frame
    protected void Update()
    {
        Drive();
    }
    //ABSTRACTION
    protected void Drive()
    {
        if (isOnGround)
        {
            carRb.AddForce(transform.forward * Speed * speedMultiplier * Time.deltaTime, ForceMode.Force);
        }
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
    protected void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plane"))
        {
            Destroy(gameObject);
        }
    }
}



