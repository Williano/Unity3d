using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component.
    public Rigidbody Rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forwared force
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            Rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            Rb.AddForce(-forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
