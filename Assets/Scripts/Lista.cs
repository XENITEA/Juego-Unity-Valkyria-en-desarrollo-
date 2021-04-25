using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    public List<string> ordenNotas = new List<string>();
    public string codigoActual = "";
    public static bool canPressNote;
    public KeyCode keyToPress;
    public Collider2D lastCollider2D;

    //Lista de combinaciones (por ahora de prueba nomas)
    // RRGY = Ataque Cercano
    // YGGR = Ataque Lejano
    // GRGY = Defensa    

    private void OnTriggerEnter2D(Collider2D other)
    {
        lastCollider2D = other;
        Debug.Log(lastCollider2D);
        canPressNote = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canPressNote = false;
        Debug.Log("NO pudo tocarse");
    }

    private void Update()
    {
        if (canPressNote == true)
        {
            if (Input.GetKey(keyToPress))
            {
                Debug.Log("Note Hit");
                if (ordenNotas.Count < 4)
                {
                    print("Se ha añadido: " + lastCollider2D.gameObject.name);
                    ordenNotas.Add(lastCollider2D.gameObject.name);
                    lastCollider2D.gameObject.SetActive(false);

                    //Codigo actual
                    codigoActual += lastCollider2D.tag;
                }
                
                if(ordenNotas.Count == 4)
                {
                    print("se ha introducido el patron" + codigoActual);

                    //comparar si el patron introducido es correcto
                    //realizar accion del patron correcto
                    PatronesCorrectos();

                    //reiniciar codigo
                    codigoActual = "";
                    ordenNotas.Clear();
                }
            }
        }
    }
    public void PatronesCorrectos()
    {
        switch (codigoActual)
        {
            case "RRVA":
                Debug.Log("Has atacado de cerca");
                break;
            case "AVVR":
                Debug.Log("Has atacado de lejos");
                break;
            case "VRVA":
                Debug.Log("Te Has Defendido");
                break;
            default:
                Debug.Log("Codigo Desconocido");
                break;
        }
    }

}
