using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePark : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != new Vector3(0, 0, 0)){
        player.transform.position=Vector3.MoveTowards(player.transform.position, target, speed * Time.deltaTime);
        }
    }
    public void Clicked (){
        Debug.Log("Clicked at post" + Input.mousePosition);
        Vector3 worldPosition = gameObject.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        Vector3 fixPosition = new Vector3(worldPosition.x, worldPosition.y, 0);
        target = fixPosition;
        //player.transform.position = fixPosition;
    }
}
