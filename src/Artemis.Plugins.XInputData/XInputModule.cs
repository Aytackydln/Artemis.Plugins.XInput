using System.Collections.Generic;
using Artemis.Core.Modules;
using JetBrains.Annotations;

namespace Artemis.Plugins.XInputData;

[UsedImplicitly]
public class XInputModule : Module<ControllersDataModel>
{
    public override void Enable()
    {
    }

    public override void Disable()
    {
    }

    public override void Update(double deltaTime)
    {
    }

    public override List<IModuleActivationRequirement>? ActivationRequirements => null;
}