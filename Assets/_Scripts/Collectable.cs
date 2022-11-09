using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int score;
    public int heal;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            if (score != 0) 
            {
                ScoreManager.instance.ChangeScore(score);
            }
            else if (heal != 0)
            {

            }
                
        }
  
        Destroy(gameObject);

    }
}
