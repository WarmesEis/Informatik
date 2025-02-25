using UnityEngine;

public class bulletscript : MonoBehaviour

{
    public GameObject Bullet;
    public Collider2D Player;
    public float speed = 4.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += transform.right * Time.deltaTime * speed; //Die bullet fliegt vorwaerts
    }
    void OnTriggerEnter2D (Collider2D collision){ //wenn etwas mit der Bullet collidiert
       if (collision.gameObject.TryGetComponent<Player>(out Player PlayerComponent)){ //Wird geschaut ob es sich um einen player handelt
          Destroy (Bullet); //bullet wird zerstoert
          PlayerComponent.TakeDamage(1); //der player kriegt damage
      }
      else {
        Destroy(Bullet); //sonst einfach nur zerstoert
      }
       
    }
   
   }


