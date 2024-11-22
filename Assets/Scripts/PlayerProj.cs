using UnityEngine;

public class PlayerProj : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.Move(rb.position + Vector3.forward * speed * Time.deltaTime, Quaternion.Euler(0, 0, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Destroy(this);
        }
    }
}
