//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Robert M. Scheller, James B. Domingo

using Landis.Core;
using Landis.SpatialModeling;

namespace Landis.Library.BiomassCohorts
{
    /// <summary>
    /// Information about a cohort's death.
    /// </summary>
    public class PartialDeathEventArgs
    {
        private ICohort cohort;
        private ActiveSite site;
        private ExtensionType disturbanceType;
        private float reduction;
        private int newStandingDeadBiomass;

        //---------------------------------------------------------------------

        /// <summary>
        /// The cohort that died.
        /// </summary>
        public ICohort Cohort
        {
            get
            {
                return cohort;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The site where the cohort died.
        /// </summary>
        public ActiveSite Site
        {
            get
            {
                return site;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The type of disturbance that killed the cohort.
        /// </summary>
        /// <remarks>
        /// null if the cohort died during the growth phase of succession.
        /// </remarks>
        public ExtensionType DisturbanceType
        {
            get
            {
                return disturbanceType;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The percent mortality by which live cohorts were reduced by disturbance.
        /// </summary>
        public float Reduction
        {
            get
            {
                return reduction;
            }
        }
        //---------------------------------------------------------------------

        /// <summary>
        /// The biomass of mortality by which live cohorts were reduced by disturbance.
        /// </summary>
        public int NewStandingDeadBiomass
        {
            get
            {
                return newStandingDeadBiomass;
            }
        }   

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public PartialDeathEventArgs(ICohort cohort,
                              ActiveSite site,
        //                      ExtensionType disturbanceType, float reduction)
            ExtensionType disturbanceType, float reduction, int newStandingDeadBiomass)
            // JRF - Testing. Change reduction to an integer so that you capture the exact amount of biomass removed from live cohorts to add to woody pool on forest floor.
        {
            this.cohort = cohort;
            this.site = site;
            this.disturbanceType = disturbanceType;
            this.reduction = reduction;
            this.newStandingDeadBiomass = newStandingDeadBiomass;
        }
    }
}
