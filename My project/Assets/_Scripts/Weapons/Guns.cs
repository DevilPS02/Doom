using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon/New Weapon")]

public class Guns : ScriptableObject
{
    public float range;
    public int verticalRange;
    public int horizontalRange;
    public float fireRate;
    public int damage;
    public AudioClip sound;
}
