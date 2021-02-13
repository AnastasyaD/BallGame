using UnityEngine;


namespace AnastasyaD
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        public bool IsInteractable { get; set; } = true;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            other.gameObject.GetComponent<Player>()?.FinishGame();
            IsInteractable = false;
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject, 6.0f);
        }
        
        public abstract void Interaction();
    }
}

