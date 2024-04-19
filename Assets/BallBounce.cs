using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
   

  Rigidbody _rb;
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            // Increase max angular velocity or we won't see much spin.
        
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                _rb.AddForce(Vector3.up * 100);
            }
                
        }
       







}
