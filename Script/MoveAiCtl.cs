using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAiCtl : MonoBehaviour
{
    [SerializeField] private Transform aPos;
    [SerializeField] private Transform bPos;
    [SerializeField] private Transform obstacle;
    [SerializeField] private float speed;
   
    private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        //set diem dau diem cuoi
        aPos.position = transform.position;
        // bPos = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);
        target = bPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        obstacle.position = Vector3.MoveTowards(obstacle.position, target, speed * Time.deltaTime);

        // if(Vector3.Distance(transform.position, aPos.position) < 0.001f)
        if (obstacle.position == aPos.position)
        {
            target = bPos.position;
        }     
        // else if(Vector3.Distance(transform.position, bPos.position) < 0.001f)
        if (obstacle.position == bPos.position)
        {
            target = aPos.position;
        }
    }
}
