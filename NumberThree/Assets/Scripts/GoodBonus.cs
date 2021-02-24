using System.Collections;
using UnityEngine;


namespace AnastasyaD
{
    public sealed class GoodBonus : InteractiveObject, IFlay, IFlicker, IRotation

    {
        private Material _material;
        private float _lengthFlay;
        private float _speedRotation;
        private CameraBonus _cameraBonus;
        
        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(0.1f, 1.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
            _cameraBonus = new CameraBonus();
        }

        IEnumerator waitingTime(float second)
        {
            yield return new WaitForSeconds(second);
            _cameraBonus.AllView();
        }
        
        public override void Interaction()
        {
            _cameraBonus.AllView();
            StartCoroutine(waitingTime(2.5f));
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 0.5f));
        }
        
        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }
}

