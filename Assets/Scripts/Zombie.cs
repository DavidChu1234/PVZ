using System;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Rigidbody rb;
    float speed;
    int hp = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = UnityEngine.Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.Move(rb.position + Vector3.back * speed * Time.deltaTime, Quaternion.Euler(0,0,0));
        checkHP();
    }

    private void checkHP()
    {
        if (hp < 0)
        {
            Destroy(this);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerProj")
        {
            hp--;
            Debug.Log("yes");
            Destroy(collision.gameObject);
        }
    }
    public void SetHP()
    {
        hp--;
    }
}
