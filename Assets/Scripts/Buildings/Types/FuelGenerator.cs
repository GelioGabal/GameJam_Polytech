using UnityEngine;

[CreateAssetMenu(fileName = "FuelGenerator", menuName = "Buildings/Generators/FuelGenerator")]
public class FuelGenerator : Building
{
    [SerializeField] float energyPerWork;
    [SerializeField][Range(0, 2)] float pollutionPerWork;
}
