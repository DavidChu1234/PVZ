using UnityEngine;

public class Zombie : MonoBehaviour
{
    Rigidbody rb;
    float speed;
    int hp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.Move(rb.position + Vector3.back * speed * Time.deltaTime, Quaternion.Euler(0,0,0));
    }

}
