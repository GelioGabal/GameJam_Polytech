using UnityEngine;

public class APlaceController:MonoBehaviour
{
    BuildMovementController build = new BuildMovementController();
    public bool isPlayced;


    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}