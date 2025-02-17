using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private healthSystem playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
    }

    void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
    } 
}
