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
        
       
        
        
        
         if ( mouseWorldPosition.x <=- 4 )
         {
            this.transform.position = leftBorder.transform.position;
         }
         else if ( mouseWorldPosition.x >= 4 )
         {
            this.transform.position = rightBorder.transform.position;
         }
         else if (mouseWorldPosition.x >= -3.98 && mouseWorldPosition.x <= 3.98)
         {
            
             transform.position = mouseWorldPosition;
         }
        
    }
}
