using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    public ActionBasedController controller;
    public Hand hand;
    private float grip;

    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    void Update()
    {
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());
    }
}
