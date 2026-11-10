using Unity.VisualScripting;
using UnityEngine;

public class TaskTwoHiddenTrap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject hiddentrap;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hiddentrap.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 20;
            hiddentrap.SetActive(true);
        }
        
    }
}
