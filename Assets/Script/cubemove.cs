using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cubemove : MonoBehaviour {

public float speed;
public float XMovement;

public float YMovement;

public bool MoveOnCollision = false;

public float ZMovement;

public Vector3 RotateSpeed = new Vector3(0,0,0);
public bool xposSwitch = false;
public bool yposSwitch = false;
public bool zposSwitch = false;

private Vector3 originalPosition;

private float xpos;
private float ypos;
private float zpos;

private bool readyToMove = false;
                // Use this for initialization
                void Start () {
                originalPosition = transform.position;
                ypos = transform.position.y;
                xpos = transform.position.x;
                zpos = transform.position.z;
                }

                
                // Update is called once per frame
                void Update () {                
                            if (MoveOnCollision)
                            {
                                if (readyToMove)
                                {
                                      initiateMovement();
                                }
                            }    
                            else
                            {
                             initiateMovement();
                            }

                }



void initiateMovement()
{
        if (XMovement > 0) XMove();
        if (YMovement > 0) YMove();
        if (ZMovement > 0) ZMove();
        transform.position = new Vector3(xpos,ypos,zpos);
        RotateOject();
}
                public void RotateOject()
                {
                    transform.Rotate(RotateSpeed);
                }

                void OnCollisionEnter (Collision col){
                    if (col.gameObject.tag == "Player")
                    {
                        readyToMove = true;
                    }
                }

                public void XMove()
                {
                                if (xposSwitch)
                                {
                                                xpos -= speed * Time.timeScale;
                                }
                                else
                                {
                                                xpos += speed * Time.timeScale;;
                                }
                                if (xpos >  originalPosition.x + XMovement)
                                {
                                                xposSwitch = true;
                                }
                                if (xpos < originalPosition.x - XMovement)
                                {
                                                xposSwitch = false;
                                }
                }

                                public void YMove()
                {
                                if (yposSwitch)
                                {
                                                ypos -= speed * Time.timeScale;;
                                }
                                else
                                {
                                                ypos += speed * Time.timeScale;;
                                }
                                if (ypos > originalPosition.y + YMovement)
                                {
                                                yposSwitch = true;
                                }
                                if (ypos < originalPosition.y - YMovement)
                                {
                                                yposSwitch = false;
                                }
                }

                                                public void ZMove()
                {
                                if (zposSwitch)
                                {
                                                zpos -= speed * Time.timeScale;;
                                }
                                else
                                {
                                                zpos += speed * Time.timeScale;;
                                }
                                if (zpos > originalPosition.z + ZMovement)
                                {
                                                zposSwitch = true;
                                }
                                if (zpos < originalPosition.z - ZMovement)
                                {
                                                zposSwitch = false;
                                }
                }
}