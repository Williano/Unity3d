using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Reference to the Rigidbody component called rb.
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    /* We use 'FixedUpdate() method when you to mess with
       physics stuff like "Adding Forces", "Changing Velocity", etc.
    */
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
