using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Test:MonoBehaviour
{
    APlaceController control = new APlaceController();
    private void Update()
    {
        Debug.Log(control.isPlayced);

    }
}
