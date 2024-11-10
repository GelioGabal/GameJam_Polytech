using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Test:MonoBehaviour
{
   // APlaceController control = new APlaceController();
   BuildMovementController b=new BuildMovementController();
    private void Update()
    {
        Debug.Log(b.ColiderEnter);

    }
}
