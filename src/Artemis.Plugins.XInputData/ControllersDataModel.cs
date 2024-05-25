using Artemis.Core.Modules;
using JetBrains.Annotations;

namespace Artemis.Plugins.XInputData;

[PublicAPI]
public class ControllersDataModel : DataModel
{
    public ControllerNode Controller1 { get; } = new(0);
    public ControllerNode Controller2 { get; } = new(1);
    public ControllerNode Controller3 { get; } = new(2);
    public ControllerNode Controller4 { get; } = new(3);
}