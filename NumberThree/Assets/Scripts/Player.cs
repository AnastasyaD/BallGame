using UnityEngine;
using UnityEngine.SceneManagement;


namespace AnastasyaD
{
    public class Player : MonoBehaviour
    {

        [SerializeField]private float Speed = 5f;
        private InteractiveObject[] _interactiveObjects;
        private Rigidbody _rigidbody;
        private Coin[] _coins; 
        private DisplayBonuses _displayScore;
        private const string SceneName = "SampleScene";
        
        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
            _rigidbody = GetComponent<Rigidbody>();
            _coins = FindObjectsOfType<Coin>(); 
        }

        public void FinishGame()
        {
            if (DisplayBonuses._score == _coins.Length) 
            {
                Time.timeScale = 0f;
                SceneManager.LoadScene (SceneName, LoadSceneMode.Single ); 
            }
        }
        
        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i]; 
     
                if (interactiveObject == null)
                {
                    continue;
                }
                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
            }
        }
        
        protected void Move()
        {
            float moveHoris = -Input.GetAxis(AxisManager.Horizontal);
            float moveVert = Input.GetAxis(AxisManager.Vertical);
            Vector3 movement = new Vector3(-moveVert, 0.0f,-moveHoris);
            _rigidbody.AddForce(movement * Speed);
        }
    }
}
