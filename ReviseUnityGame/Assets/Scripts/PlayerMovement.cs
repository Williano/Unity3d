using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
