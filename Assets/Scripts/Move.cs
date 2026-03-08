using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 0.5f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float valueX = Input.GetAxis("Horizontal");
        float valueY = 0;
        float valueZ = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(valueX, valueY, valueZ) * playerSpeed;
        rb.linearVelocity = new Vector3(moveDirection.x, rb.linearVelocity.y, moveDirection.z);
    }
}
