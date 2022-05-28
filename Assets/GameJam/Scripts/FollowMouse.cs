using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Transform leftBorder;
    [SerializeField]
    private Transform rightBorder;
    [SerializeField]
    private float maxSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.y = -3.5f;
        mouseWorldPosition.z = 0f;
           
        //Check for when player reach left border
         if ( mouseWorldPosition.x <=- 2.9 )
         {
             Cursor. visible = true;
            this.transform.position = rightBorder.transform.position;
         }
         //Check for when player reach right border
         else if ( mouseWorldPosition.x >= 2.9 )
         {
             Cursor. visible = true;
            this.transform.position = leftBorder.transform.position;
         }
         //Check for when player is in the middle 
         else if (mouseWorldPosition.x >= -2.15 && mouseWorldPosition.x <= 2.15)
         {
             Cursor. visible = false;
            //transform.position = Vector2.MoveTowards(transform.position, mouseWorldPosition, maxSpeed*Time.deltaTime);
            transform.position = mouseWorldPosition;
         }
         
    }
    
    
}
