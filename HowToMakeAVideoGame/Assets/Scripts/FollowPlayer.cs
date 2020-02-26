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
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = player.position;
        }

    }
}
