using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.Move(rb.position + Vector3.left*3.5f, Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.Move(rb.position + Vector3.right*3.5f, Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

        }
    }
}
