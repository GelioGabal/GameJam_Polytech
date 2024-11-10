using UnityEngine;
using UnityEngine.InputSystem;

public class BuildMovementController:MonoBehaviour
{
    [SerializeField] LayerMask ground;
    Camera cam;
    //APlaceController controller=new APlaceController();
    public bool ColiderEnter = false;


    /*   private void FixedUpdate()
       {
           if (gameObject.GetComponent<BuildMovementController>() == null)
               isPlayced = true;
       }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ColiderEnter = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ColiderEnter = false;
    }

    private void Awake()
    {
       
        cam=Camera.main;
    }

    private void BuildMovenent(Vector2 position)
    {
        position=cam.ScreenToWorldPoint(position);
        transform.position = position;
        
    }

    

    private void PlaceObject()
    {
        
        BuildMovenent(InputSync.input.Standart.MousePos.ReadValue<Vector2>());
        if (ColiderEnter==false)
        {
            if (InputSync.input.Standart.leftCkick.IsPressed())
            {

                transform.position = new Vector2(transform.position.x, transform.position.y);
                Destroy(gameObject.GetComponent<BuildMovementController>());
                gameObject.AddComponent<Rigidbody2D>();
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;


            }
        }
        else
        {
            Debug.Log("тут нельзя строить");
        }

    }
    

    private void FixedUpdate()
    {
        
        PlaceObject();
    }



}
