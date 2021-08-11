using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    //public GameObject ThePlayer;
    //public float TargetDistance;
    //public float AllowedDistance = 5;
    //public GameObject TheEnemy;
    //public float FollowSpeed;
    //public RaycastHit Shot;
/*
    private void Update() {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if(TargetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.2f;
                TheEnemy.GetComponent<Animation>().Play("mixamo.com");
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);

            }
        }
    }
*/

    public Transform target;
    public float speed = 3f;
    Rigidbody rig;

    private void Start() {
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }
       
}
