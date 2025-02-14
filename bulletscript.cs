using UnityEngine;

public class bulletscript : MonoBehaviour

{
    public GameObject Bullet;

    public Collider2D Player;
    public Lebensanzeigescript lebensanzeigescript; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D Player){
        Destroy (Bullet);
        lebensanzeigescript.leben = lebensanzeigescript.leben -1;
    }
   
   }


