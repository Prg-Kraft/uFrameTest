// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using test;
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class TestSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<meineTestComp> _meineTestCompManager;
        
        private IEcsComponentManagerOf<TestComponentNode> _TestComponentNodeManager;
        
        private IEcsComponentManagerOf<playerComp> _playerCompManager;
        
        private IEcsComponentManagerOf<NewGroupNode> _NewGroupNodeManager;
        
        private TestSystemOnMouseDownHandler TestSystemOnMouseDownHandlerInstance = new TestSystemOnMouseDownHandler();
        
        public IEcsComponentManagerOf<meineTestComp> meineTestCompManager {
            get {
                return _meineTestCompManager;
            }
            set {
                _meineTestCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<TestComponentNode> TestComponentNodeManager {
            get {
                return _TestComponentNodeManager;
            }
            set {
                _TestComponentNodeManager = value;
            }
        }
        
        public IEcsComponentManagerOf<playerComp> playerCompManager {
            get {
                return _playerCompManager;
            }
            set {
                _playerCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<NewGroupNode> NewGroupNodeManager {
            get {
                return _NewGroupNodeManager;
            }
            set {
                _NewGroupNodeManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            meineTestCompManager = ComponentSystem.RegisterComponent<meineTestComp>(2);
            TestComponentNodeManager = ComponentSystem.RegisterComponent<TestComponentNode>(1);
            playerCompManager = ComponentSystem.RegisterComponent<playerComp>(3);
            NewGroupNodeManager = ComponentSystem.RegisterGroup<NewGroupNodeGroup,NewGroupNode>();
            this.OnEvent<uFrame.ECS.UnityUtilities.MouseDownDispatcher>().Subscribe(_=>{ TestSystemOnMouseDownFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void TestSystemOnMouseDownHandler(uFrame.ECS.UnityUtilities.MouseDownDispatcher data, TestComponentNode source) {
            var handler = TestSystemOnMouseDownHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            StartCoroutine(handler.Execute());
        }
        
        protected void TestSystemOnMouseDownFilter(uFrame.ECS.UnityUtilities.MouseDownDispatcher data) {
            var SourceTestComponentNode = TestComponentNodeManager[data.EntityId];
            if (SourceTestComponentNode == null) {
                return;
            }
            if (!SourceTestComponentNode.Enabled) {
                return;
            }
            this.TestSystemOnMouseDownHandler(data, SourceTestComponentNode);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("2667ea79-0597-4e9c-8973-88b2b0298978")]
    public partial class TestSystem : TestSystemBase {
        
        private static TestSystem _Instance;
        
        public TestSystem() {
            Instance = this;
        }
        
        public static TestSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
