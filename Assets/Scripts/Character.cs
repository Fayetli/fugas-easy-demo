using Gameplay.Collectable;
using UnityEngine;

namespace Gameplay
{
    public class Character : MonoBehaviour
    {
        public int Coins { get; private set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Coin>(out var coin))
            {
                Coins += coin.Collect();
                Debug.Log("Coins: " + Coins);
            }
    }
    }
}