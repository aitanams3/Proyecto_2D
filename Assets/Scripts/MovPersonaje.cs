using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float velocidad = 5f;
    private float multiplicador = 5f;
    public float multiplicadorSalto = 5f; 
    private bool puedoSaltar = true;
    private Rigidbody2D rb;
    private Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 

        animatorController = this.GetComponent<Animator>();

        transform.position = new Vector3(-3.1f, -1.0f, 0); 
    }

    // Update is called once per frame
    void Update()
    {

        float miDeltaTime = Time.deltaTime;

        //MOVIMIENTO
        float movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)
        //float movTeclasY = Input.GetAxis("Vertical"); //(a -1f - d 1f)

        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        //izq
        if(movTeclas < 0){
             this.GetComponent<SpriteRenderer>().flipX = true;   
        }else if(movTeclas > 0){
        //dcha
            this.GetComponent<SpriteRenderer>().flipX = false;
        }


       //ANIMACIÓN WALKING

       if(movTeclas != 0){
            animatorController.SetBool("activaCamina", true);
       }else{
            animatorController.SetBool("activaCamina", false);
       }


        //SALTO
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);

        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
            puedoSaltar = true;
            Debug.Log(hit.collider.name);
        }else{
            puedoSaltar = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
             rb.AddForce(
                new Vector2(0,multiplicadorSalto),
                ForceMode2D.Impulse
            );
            //puedoSaltar = false;
        }
    }

    /*
    void OnCollisionEnter2D(){
       puedoSaltar = true;
       Debug.Log("Collision");
    }
    */

}
