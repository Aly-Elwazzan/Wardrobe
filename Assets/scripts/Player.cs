using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string Name; //player name
    public int Attack; //attack power
    public float AttackSpeed; //how fast we attack

    

  
    public float speed = 10;
    
    public float maxVelocityChange = 10;
   


    private Transform PlayerTransform;
  

    // Start is called before the first frame update
    void Start()
    {

        
        PlayerTransform = GetComponent < Transform >();
        
      //  rb.useGravity = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerTransform.transform.Rotate(0, Input.GetAxis("Horizontal"), 0); //rotate mn n7yet el  y + or -   lma  ygelak     a aw d  //     <- or ->   

       /* Vector3 targetVelocity = new Vector3(0, 0, Input.GetAxis("Vertical"));
        targetVelocity = PlayerTransform.TransformDirection(targetVelocity);
        targetVelocity = targetVelocity * speed;*/

      /*  Vector3 velocity = rb.velocity;
        Vector3 velocityChange = targetVelocity - velocity;

        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);   //7la2 3la el  velocitychange  lw  zadet aw  a2lt 3n el  maxx
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;  //mt5lesh fe  velocity change  etgah el  y*/

        

        
        

        
    }

    private void OnCollisionStay()
    {
       
    }

   
}

 


