using Unity.Mathematics;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;   
    }

    public void takeDamage(float _damage)   
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth > 0){
            //player kassiert schaden
        }
        else{
            //player ist tot
            GetComponent<playerController>().enabled = false;
        }

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            takeDamage(1);
        }
    } 
}
