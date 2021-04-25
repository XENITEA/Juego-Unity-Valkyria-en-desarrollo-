using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida;
    public bool isPlayer;
    private void Update()
    {
        if (vida <= 0)
        {
            if (!isPlayer)
            {
                //muerte enemigo
                Destroy(gameObject);
                Debug.Log("ENEMIGO ha muerto");
                //Efecto muerte
            }
            else
            {
                Debug.Log("VALKYRIA ha muerto");
                //muerte protagonista
                //aparece menu
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bala"))
        {
            vida--;           
        }
    }

}
