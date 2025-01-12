global using System.Numerics;
using Ego;
using ImGuiNET;
using MessagePack;
using MessagePack.Resolvers;
using Serilog;

namespace GameTest;

[MessagePackObject(true)]
public struct TestStruct
{
    public string hello = "Yup";

    public TestStruct()
    {
    }
}

[MessagePackObject(true)]
public struct TestClass
{
    public string Hello2 = "Yuppers";
    public string Hello3 = "Yuppers";
    public int Yep = 15;

    public TestClass()
    {
    }
}

[Node]
public partial class Root : Node3D
{
    private void Inspect()
    {
        DefaultInspect();
        ImGui.Text("TestNode"); 
    }
}

[Node] 
public partial class Mover : Node3D
{
    [Inspect] private Vector3 Velocity = new Vector3(0f, 0f, 1f);
    [Inspect] private Vector3 Velocity2 = new Vector3(0f, 0f, 1f);

    protected override void Update()
    {
        base.Update();

        //LocalPosition += Velocity * (float)Time.DeltaSeconds;
    }
    
    private void Inspect()
    {
        DefaultInspect();
    }
}
[Node] 
public partial class Scaler : Node3D
{
    [Inspect] private Vector3 Velocity = new Vector3(0f, 0f, 1f);

    protected override void Update()
    {
        base.Update();

        LocalScale += Velocity * (float)Time.DeltaSeconds;
    }
    
    private void Inspect()
    {
        DefaultInspect();
        ImGui.Text("nsrteirsntiert");
    }
}
