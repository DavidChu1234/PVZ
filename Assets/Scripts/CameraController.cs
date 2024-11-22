using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = player.transform.position;
    }
}
