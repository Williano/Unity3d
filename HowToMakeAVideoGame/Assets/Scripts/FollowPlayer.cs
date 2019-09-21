using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        // First person view. Camera inside player.
        if (Input.GetKey("s"))
        {
            transform.position = player.position;
        }

    }

    void FixedUpdate()
    {
        // First person view. Camera inside player.
        if (Input.GetKey("s"))
        {
            transform.position = player.position;
        }
    }
}
