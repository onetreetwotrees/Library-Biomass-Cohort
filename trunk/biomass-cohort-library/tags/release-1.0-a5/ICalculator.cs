using Landis.Landscape;

namespace Landis.Biomass
{
    /// <summary>
    /// A calculator for computing the change in an individual cohort's biomass
    /// due to annual growth and mortality.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// The total mortality (excluding annual leaf litter) for the cohort
        /// that was passed as a parameter in the most recent call to the
        /// ComputeChange method.
        /// </summary>
        /// <remarks>
        /// Reflects the cohort's contribution to the growing space available
        /// next year.
        /// </remarks>
        int MortalityWithoutLeafLitter
        {
            get;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Computes the change in an individual cohort's biomass due to annual
        /// growth and mortality.
        /// </summary>
        /// <param name="cohort">
        /// The cohort whose biomass the change is to be computed for.
        /// </param>
        /// <param name="site">
        /// The site where the cohort is located.
        /// </param>
        /// <param name="siteBiomass">
        /// The total biomass at the site.
        /// </param>
        /// <param name="prevYearSiteMortality">
        /// The total mortality at the site during the previous year.
        /// </param>
        int ComputeChange(ICohort    cohort,
                          ActiveSite site,
                          int        siteBiomass,
                          int        prevYearSiteMortality);
    }
}
