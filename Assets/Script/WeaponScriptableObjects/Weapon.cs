using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName = "WeaponStat",menuName = "ScriptableObject/Weapon")]
public class Weapon:ScriptableObject {
    public float damage = 10f;
    public float reloadSpeed = 2f;
    public AudioClip attackSound;
    public PrefabAssetType WeaponModel;
    public Projectile projectileModel;
    

}