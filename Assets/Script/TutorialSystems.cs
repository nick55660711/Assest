public class TutorialSystems : Feature
{
    // 添加所有要用到的System，base里面是调试节点的名字
    public TutorialSystems(Contexts contexts) : base("Tutorial Systems")
    {
        Add(new HelloWorldSystem(contexts));
        Add(new CleanupDebugMessageSystem(contexts));
        Add(new LogMouseClickSystem(contexts));
        Add(new CreateMoverSystem(contexts));
        Add(new AddViewSystem(contexts));
        Add(new EmitInputSystem(contexts));
        Add(new RenderSpriteSystem(contexts));
        Add(new RenderPositionSystem(contexts));
        Add(new RenderDirectionSystem(contexts));
        Add(new CommandMoveSystem(contexts));
        Add(new MoveSystem(contexts));
        Add(new MiddleMouseKeyChangeSpriteSystem(contexts));
        Add(new DebugMessageSystem(contexts));

    }
}

