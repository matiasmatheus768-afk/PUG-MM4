using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject telaPreta;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ENTROU NO PORTAL!");

            other.gameObject.SetActive(false);

            if (telaPreta != null)
            {
                telaPreta.SetActive(true);
            }

            Time.timeScale = 0f;
        }
    }
}