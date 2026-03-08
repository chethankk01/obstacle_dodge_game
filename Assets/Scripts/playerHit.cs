using Unity.VisualScripting;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    private int hitCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            ChangeColor(collision.gameObject, Color.blue);
        }
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        Material mat = mr.material;
        mat.color = color;
    }
}
