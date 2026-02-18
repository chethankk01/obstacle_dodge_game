using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float valueX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float valueY = 0;
        float valueZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(valueX, valueY, valueZ);
    }
}
