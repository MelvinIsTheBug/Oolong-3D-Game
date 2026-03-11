using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
     public float speed = 10f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, speed * Time.deltaTime);
        
    }

      private void OnTriggerEnter(Collider other)
    {
        //get a reference to the PlayerCharacter component, if there is one
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();

        //if the player is not null, then the fireball has hit the player
        if (player != null)
        {
            //Debug.Log("player hit!");
            player.Hurt(damage);
        }

        //Destroy Game object
        Destroy(this.gameObject);
    }
}
