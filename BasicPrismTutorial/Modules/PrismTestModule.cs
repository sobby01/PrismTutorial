using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using PrismTestUtilities;

namespace Modules
{
    public class PrismTestModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public PrismTestModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;   
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion(Constants.MainRegion, typeof(PrismTest));
        }
    }
}
