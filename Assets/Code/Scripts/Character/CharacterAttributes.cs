using UnityEngine;

namespace RoguelikeFPS.Character
{
    [CreateAssetMenu(menuName = "Character/CharacterAttributes")]
    public class CharacterAttributes : ScriptableObject
    {
        [field: SerializeField]
        public int MaxHealth { get; private set; }
        [field: SerializeField]
        public float HorizontalMovementSpeed { get; private set; }
        [field: SerializeField]
        public float JumpStrength { get; private set; }
        [field: SerializeField]
        public float Gravity { get; private set; }
    }
}
