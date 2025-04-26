using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        Debug.Log(col);

        if(col.name == "Personaje"){
            GameManager.puntos += 1;

            Destroy(this.gameObject, 0f);
        }

    }




}
