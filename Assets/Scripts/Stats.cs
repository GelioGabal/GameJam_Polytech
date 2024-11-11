using UnityEngine;

public class Stats: MonoBehaviour
{
    public static Stat Energy, Materials, Purity;
    private void Awake()
    {
        Energy = new("energy");
        Materials = new("materials");
        Purity = new("purity");
    }
}
