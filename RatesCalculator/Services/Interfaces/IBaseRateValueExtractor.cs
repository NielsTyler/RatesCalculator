namespace RatesCalculator.Services.Interfaces
{
    using RatesCalculator.DAL.Domain.Enums;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IBaseRateValueExtractor" />.
    /// </summary>
    public interface IBaseRateValueExtractor
    {
        /// <summary>
        /// The RetrieveBasicRateValueAsync.
        /// </summary>
        /// <param name="basicValueCode">The basicValueCode<see cref="EBaseRateCode"/>.</param>
        /// <returns>The <see cref="Task{decimal}"/>.</returns>
        Task<decimal> RetrieveBasicRateValueAsync(EBaseRateCode basicValueCode);
    }
}
