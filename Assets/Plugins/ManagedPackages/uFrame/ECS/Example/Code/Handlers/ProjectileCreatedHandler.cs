// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class ProjectileCreated {
        
        public Projectile Group;
        
        private Projectile _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode9_go = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode9_component = default( UnityEngine.MonoBehaviour );
        
        private UnityEngine.Rigidbody ActionNode9_Result = default( UnityEngine.Rigidbody );
        
        private UnityEngine.Vector3 ActionNode10_a = default( UnityEngine.Vector3 );
        
        private float ActionNode10_b = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode10_Result = default( UnityEngine.Vector3 );
        
        public Projectile Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode9_go = Group.Entity.gameObject;
            // ActionNode
            while (this.DebugInfo("6d0e5ea6-5e27-474d-be32-2d7c8dea900c","1b8855ac-da78-4205-90d0-39cd7b780e95", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.UnityLibrary.GetRigidbody
            ActionNode9_Result = uFrame.ECS.Actions.UnityLibrary.GetRigidbody(ActionNode9_go, ActionNode9_component);
            ActionNode10_a = Group.Direction;
            ActionNode10_b = Group.Speed;
            // ActionNode
            while (this.DebugInfo("1b8855ac-da78-4205-90d0-39cd7b780e95","cd2165a3-d9c2-43b8-b386-dc88375887fc", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.Vector3Library.Multiply
            ActionNode10_Result = uFrame.ECS.Actions.Vector3Library.Multiply(ActionNode10_a, ActionNode10_b);
            // SetVariableNode
            while (this.DebugInfo("cd2165a3-d9c2-43b8-b386-dc88375887fc","f769312f-1b19-4c43-8564-3242e66bc0b5", this) == 1) yield return null;
            ActionNode9_Result.velocity = (UnityEngine.Vector3)ActionNode10_Result;
            yield break;
        }
    }
}