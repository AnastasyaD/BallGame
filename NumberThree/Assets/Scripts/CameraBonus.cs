using UnityEngine;


namespace AnastasyaD
{
    public class CameraBonus
    {
        private GameObject _gameObject;
        private Camera _camera;
        private float _cameraDepth;

        public float CameraDepth
        {
            get => _cameraDepth;
        }
        
        public CameraBonus()
        {
            _gameObject = GameObject.FindGameObjectWithTag("CameraBonus");
            _camera = _gameObject.GetComponent<Camera>();
            _cameraDepth = _camera.depth; // текущая глубина камеры
        }
        
        public void AllView()
        {
            if (_camera.depth == 0)
            {
                _camera.depth = -5.0f;
            }
            else
            {
                _camera.depth = 0;
            }
        }
    }
}