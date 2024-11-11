using UnityEngine;

public abstract class Building : ScriptableObject
{
    [Header("To buy")]
    [SerializeField] float materialsPrice;
    [Header("Common")]
    [SerializeField] Sprite sprite;
    [SerializeField] string displayedName;
    public float Price { get => materialsPrice; }
    public string Name { get => displayedName; }
    public void SetBuilding(GameObject gameObject)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
