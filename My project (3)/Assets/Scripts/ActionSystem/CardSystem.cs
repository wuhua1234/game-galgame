// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CardSystem : MonoBehaviour
// {
//     [SerializeField] private Card cardPrefab;
//     [SerializeField] private Transform spawn;
//     [SerializeField] private Transform hand;
//     private void OnEnable()
//     {
//         ActionSystem.AttachPerformer<DrawCardGA>(DrawCardPerformer);
//     }
//     private void OnDisable()
//     {
//         ActionSystem.DetachPerformer<DrawCardGA>();
//     }
//     private IEnumerator DrawCardPerformer(DrawCardGA drawCardGA)
//     {
//         Card card = Instantiate(cardPrefab, spawn.position, Quaternion.identity);
//         Tween tween = card.transform.DOMove(hand.position, 0.5f);
//         yield return tween.WaitForCompletion();
//     }
// }
