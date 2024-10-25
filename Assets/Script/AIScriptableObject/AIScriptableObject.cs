
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "AIScriptableObject", menuName = "ScriptableObject/AI")]
public class AIScriptableObject : ScriptableObject
{
    public float health = 100;
    public float speed = 5;
    public Transform location;
    public Weapon weapon;

    void start() {
        
    }
}
