using TMPro;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
    [SerializeField] TMP_Text energyField, materialsField, purityField;
    void Start()
    {
        Stats.Energy.OnChange.AddListener(value => SetStat(energyField, value));
        Stats.Materials.OnChange.AddListener(value => SetStat(materialsField, value));
        Stats.Purity.OnChange.AddListener(value => SetStat(purityField, value));
    }

    public void SetStat(TMP_Text field, float value)
    {
        field.text = value.ToString();
    }
}
