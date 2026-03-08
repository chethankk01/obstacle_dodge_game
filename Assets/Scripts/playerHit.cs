using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHit : MonoBehaviour
{
    private int hitCount = 0;
    private Rigidbody rb;
    private Move moveScript;
    [SerializeField] private Canvas gameOverCanvas;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<Move>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverCanvas.enabled = true;
            ChangeColor(collision.gameObject, Color.blue);
            rb.constraints = RigidbodyConstraints.None;
            rb.useGravity = true;
            moveScript.enabled = false;
        }
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        Material mat = mr.material;
        mat.color = color;
    }

    public void returnToHome()
    {
        SceneManager.LoadSceneAsync("Home");
    }
}
