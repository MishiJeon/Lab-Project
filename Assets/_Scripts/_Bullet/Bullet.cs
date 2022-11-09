using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    PlayerStats playerStats;
    private void Awake()
    {
        playerStats = PlayerManager.instance.player.GetComponent<PlayerStats>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(this.gameObject);

        this.gameObject.SetActive(false);
        if(collision.gameObject.tag == "Player")
        {
            //
            playerStats.TakeDamage(playerStats.damage);
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            //
            Destroy(collision.gameObject);
        }
    }
}
