using UnityEngine;

[CreateAssetMenu(fileName = "BoatVisualSettings", menuName = "ScriptableObjects/BoatVisualSettings", order = 1)]

public class BoatVisualSettings
{
    [Tooltip("Echelle appliquée aux modèles 3D des bateaux")]
    public float modelScale = 0.4f;
}
