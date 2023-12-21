using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private int health = 1000;

    public void RemoveHealth(int amount)
    {
        health -= amount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CheckIfBroken())
        {
            BreakObject(collision);
        }
        
    }

    private void BreakObject(Collision collision)
    {
        Breakable breakable = GetComponent<Breakable>();
        breakable.breakObject(collision);
    }

    private bool CheckIfBroken()
    {
        return (health == 0);
    }
}