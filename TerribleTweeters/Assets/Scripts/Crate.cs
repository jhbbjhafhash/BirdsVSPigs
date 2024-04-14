using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Crate : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.magnitude > 7f)
        {
            StartCoroutine(Deactavate());
            GetComponent<AudioSource>().Play();
        }
    }

    
   IEnumerator Deactavate()
   {
      _particleSystem.Play();
      yield return new WaitForSeconds(.5f);
      gameObject.SetActive(false);
   }
}
