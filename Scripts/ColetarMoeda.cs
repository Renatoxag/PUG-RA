using UnityEngine;

public class ColetarMoeda : MonoBehaviour {

    public static int contador = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            contador++;
            Debug.Log("Moedas: " + contador);

            Destroy(gameObject);
        }

       
        
    }
} 
