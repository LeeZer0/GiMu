using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class HealthScript : MonoBehaviour
{
    /// <summary>
    /// Total hitpoints
    /// </summary>
    public int hp = 3;
    public int punkty = 50;
    /// <summary>
    /// Enemy or player?
    /// </summary>
    public bool isEnemy = true;

    /// <summary>
    /// Inflicts damage and check if the object should be destroyed
    /// </summary>
    /// <param name="damageCount"></param>
    public void Damage(int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            // Dead!
            Destroy(gameObject);
            PointMen.points += punkty;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Is this a shot?
        
        if (col.gameObject.name == "Cios1(Clone)" )
        {
            
            Damage(1);
        }
    }
}