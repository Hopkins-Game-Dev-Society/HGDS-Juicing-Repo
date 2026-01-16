using UnityEngine;
using DG.Tweening;
public class TweenRotate : MonoBehaviour
{
    Vector3 endRotation = new Vector3(0, 0, 180);
    private bool toggle = false;
    public void DoRotation()
    {
        if (toggle)
        {
            toggle = false;
            transform.DORotate(endRotation, 1, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1);
        }
        else
        {
            toggle = true;
            transform.DORotate(-endRotation, 1, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1);
        }
    }
}
