using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{
    [SerializeField] public GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject go in projectiles)
            {
                go.SetActive(true);
            }
        }
    }
}
