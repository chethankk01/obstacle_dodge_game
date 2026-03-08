using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Vector3 rotateAngles;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAngles);
    }
}
