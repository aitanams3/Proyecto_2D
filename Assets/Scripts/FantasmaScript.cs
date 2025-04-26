using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    Vector3 posicionInicial;
    GameObject personaje; 
    public float velocidadFantasma = 1f;


    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        //personaje = GameObject.Find("Personaje");
        personaje = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float distancia = Vector3.Distance(transform.position, personaje.transform.position);
        float velocidadFinal = velocidadFantasma*Time.deltaTime;

        if (distancia <= 3f)
        {
            transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal); 
        }

        // Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.white, 2.5f);

        // Debug.Log(personaje.transform.position.x);

    }
}
