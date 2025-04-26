using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoScript : MonoBehaviour
{

    GameObject personaje;
    bool bolaDerecha = true;
    public float speedBala = 4f;

    // Start is called before the first frame update
    void Start()
    {

        personaje = GameObject.Find("Personaje");
        bolaDerecha = personaje.GetComponent<MovPersonaje>().miraDerecha;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(bolaDerecha){
            transform.Translate (speedBala*Time.deltaTime, 0, 0, Space.World);
        }else{
            transform.Translate (speedBala*Time.deltaTime*-1, 0, 0, Space.World);
        }
        
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log(col.gameObject.name);
    }
}
