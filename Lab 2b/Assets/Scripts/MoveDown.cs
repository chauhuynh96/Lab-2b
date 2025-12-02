using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;
    private Rigidbody objectRb;
    private float zDestroy = -17.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(-Vector3.forward * speed);

        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
