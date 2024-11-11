using UnityEngine;
using UnityEngine.Events;

public class Stat
{
    float value;
    float maxCapacity;
    public UnityEvent<float> OnChange;
    string key;
    public Stat(string key)
    {
        OnChange = new();
        this.key = key;
        if (PlayerPrefs.HasKey(key))
            value = PlayerPrefs.GetFloat(key);
    }
    public float Value
    {
        get => value;
        set
        {
            this.value = Mathf.Clamp(value, 0, maxCapacity);
            PlayerPrefs.SetFloat(key, value);
            OnChange.Invoke(value);
        }
    }
    public float MaxCapacity { get => maxCapacity; set { maxCapacity = value; } }
}
