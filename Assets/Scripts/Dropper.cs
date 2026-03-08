using UnityEngine;

public class Dropper : MonoBehaviour
{
    public int timer = 3;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timer)
        {
            rb.useGravity = true;
        }

    }
}
