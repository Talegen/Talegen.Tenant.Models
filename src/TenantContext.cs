﻿/*
 *
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Talegen.AspNetCore.Multitenant
{
    /// <summary>
    /// This class implements the base tenant context.
    /// </summary>
    /// <typeparam name="TTenant">The type of the tenant.</typeparam>
    /// <seealso cref="Talegen.AspNetCore.Multitenant.ITenantContext{TTenant}" />
    public class TenantContext<TTenant> : ITenantContext<TTenant> where TTenant : class, ITenant
    {
        /// <summary>
        /// Gets or sets the tenant.
        /// </summary>
        /// <value>The tenant.</value>
        public TTenant Tenant { get; set; }
    }
}