using UnityEngine;


namespace AnastasyaD
{
    public class BadBonus : InteractiveObject, IFlay, IRotation

    {
        private float _lengthFlay;
        private float _speedRotation;
        private ReloadPosition _reloadPosition;

        private void Awake()
        {
            _lengthFlay = Random.Range(0.1f, 1.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
            _reloadPosition = new ReloadPosition();
        }

        public override void Interaction()
        {
            _reloadPosition.StartPosition();
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }
}