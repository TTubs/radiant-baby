using UnityEngine;

namespace Gamekit2D
{
    public class KeyUI : MonoBehaviour
    {
        public static KeyUI Instance { get; protected set; }

        public GameObject keyIconPrefab;
        public GameObject powerGroup;
        public string[] keyNames;

        protected Animator[] m_KeyIconAnimators;

        protected readonly int m_HashActivePara = Animator.StringToHash("Active");

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            SetInitialKeyCount();
        }

        public void SetInitialKeyCount()
        {
            if (m_KeyIconAnimators != null && m_KeyIconAnimators.Length == keyNames.Length)
                return;

            m_KeyIconAnimators = new Animator[keyNames.Length];

            for (int i = 0; i < m_KeyIconAnimators.Length; i++)
            {
                GameObject healthIcon = Instantiate(keyIconPrefab);
                healthIcon.transform.SetParent(powerGroup.transform);

                m_KeyIconAnimators[i] = healthIcon.GetComponent<Animator>();
            }

            
        }

        public void ChangeKeyUI(InventoryController controller)
        {
            for (int i = 0; i < keyNames.Length; i++)
            {
                m_KeyIconAnimators[i].SetBool(m_HashActivePara, controller.HasItem(keyNames[i]));
            }
        }
    }
}