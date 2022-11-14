using System;
using UnityEngine;

namespace Gameplay.Collectable
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int coinValue;

        public int Collect()
        {
            Destroy(gameObject);
            return coinValue;
        }
    }
}
