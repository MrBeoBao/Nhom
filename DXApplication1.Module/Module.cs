using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;

namespace DXApplication1.Module;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.
public sealed class DXApplication1Module : ModuleBase {
    public DXApplication1Module() {
		// 
		// DXApplication1Module
		// 
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.SystemModule.SystemModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.ValidationModule));
    }
    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
        ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
        return new ModuleUpdater[] { updater };
    }
    public override void Setup(XafApplication application) {
        base.Setup(application); 
    }
}
4
	232
	53
	452
	345
	2345
	2345
	234
	523
	452
	345
	2345
	2345
	234
	6532
	623
	46435
	634
	5634
	563
	456
	3456
	3456
	34
	5634
	5634
	56
	3456
	3456
	3
	45634
	563
	56
	3456
	34
	563
	56
	345
	6345634564454
	563
	456
	34
	563
	456
	3456234
	2
	342
	34
	234
	234
	234
	2
	342
	34
	2342
	34
	243
	234
	2
	432
	42
	34
	234
	243
	234
	2
	342
	4
	234
	234
	234
	2
	41
	231
	31
	4324
	5234
	5234
	56342
	65345
	7347
	3456
	3456
	23
	4523
	45
	2345
	2346
	246
	24352
	45623
	4523
	456234
	65234
	5234
	65234
	532456
	23465
	2345623
	46523
	465324
	56234
	65234
	5623
	465234
	523
	45623
	45234
	652365
	23456
	23465
	234
	23456
	23456
	4236523
	456324
	5634
	3
	3
	3
	3
	4
	354
	34
	34
	34

	43
	43
	34
	56
	345
	634
	56
	345
