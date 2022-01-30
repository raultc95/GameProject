using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector3 target;
    // Start is called before the first frame update

    //Player mirando derecha: rotation 0 o 360
    //Player mirando izquierda: rotation 180
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != new Vector3(0, 0, 0)){
            if (player.transform.position != target){
                player.GetComponent<Animator>().SetBool("walking", true);
                player.transform.position=Vector3.MoveTowards(player.transform.position, target, speed * Time.deltaTime);
            } else {
                player.GetComponent<Animator>().SetBool("walking", false); 
            }
        }
    }
    public void Clicked (){
        Debug.Log("Clicked at post" + Input.mousePosition);
        Vector3 worldPosition = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        Vector3 fixPosition = new Vector3(worldPosition.x, worldPosition.y, 0);
        target = fixPosition;
        //Comprobamos para cambiar la position de la cabeza
        if (target.x > player.transform.position.x){
            //Jugador debe mirar a la derecha
            player.transform.rotation = new Quaternion(0, 0, 0, 0);
        } else {
            //Jugador debe mirar a la izquierda
            player.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }
}
