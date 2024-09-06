
using UnityEngine;
public enum PowerUpType {  None, Pushback, Rockets, Smash}

public class PowerUp : MonoBehaviour
{
    public PowerUpType powerUpType;
    public float smashSpeed;
    public float explosionForce;
    public float explosionRadius;

    bool smashing = false;
    float floorY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
