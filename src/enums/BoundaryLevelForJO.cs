using System;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2017 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Ted Spence
 * @author Zhenya Frolov
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// BoundaryLevelForJO
    /// </summary>
    public enum BoundaryLevelForJO
    {
        /// <summary>
        /// 
        /// </summary>
        VeryPreciseFullAddress,

        /// <summary>
        /// 
        /// </summary>
        PreciseZIP9,

        /// <summary>
        /// 
        /// </summary>
        ZIP5Only,

    }
}
