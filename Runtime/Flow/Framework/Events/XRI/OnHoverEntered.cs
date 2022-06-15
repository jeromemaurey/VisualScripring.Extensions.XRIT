using System;
using Core.Events;
using Core.Events.MessageListeners.XRIEventsListeners;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Flow.Framework.Events.XRI
{
    
    /// <summary>
    /// Called when an Interactor begins hovering over this Interactable (Entered), or ends hovering (Exited).
    /// </summary>
    [UnitCategory("Events/XRI")]
    [TypeIcon(typeof(Button))]
    [UnitOrder(5)]
    
    public class OnHoverEntered : HoverEnterEventUnit
    {
        protected override string hookName => XRIEventHooks.HoverEntered;
        
        public override Type MessageListenerType => typeof(HoverEnteredMessageListener);
    }
}