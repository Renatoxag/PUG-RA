using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private float alturaMorte = -10f;

    void Update()
    {
        if (transform.position.y < alturaMorte)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
