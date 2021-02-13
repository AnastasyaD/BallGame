using UnityEngine;


namespace AnastasyaD
{
    public sealed class Coin : InteractiveObject, IFlicker
    {
        private Material _material;
        private DisplayBonuses _displayScore;
        
        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _displayScore = new DisplayBonuses();
        }

        public override void Interaction()
        {
            _displayScore.AddCoin(1);
        }
        
        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }
    }
}
