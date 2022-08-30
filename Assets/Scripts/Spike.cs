using Fugas.Demo.Movement;
using UnityEngine;

namespace Fugas.Demo.DamageSystem
{
    public class Spike : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent<PlayerMovement>(out var playerMovement))
            {
                playerMovement.ResetPosition();
            }
        }
    }
}