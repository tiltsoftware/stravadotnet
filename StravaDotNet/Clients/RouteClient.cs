#region Copyright (C) 2015 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

using Strava.Authentication;
using Strava.Routes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Strava.Clients
{
    /// <summary>
    /// Used to get routes from Strava.
    /// </summary>
    public class RouteClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the RouteClient class.
        /// </summary>
        /// <param name="auth">The IAuthentication object containing a valid access token.</param>
        public RouteClient(IAuthentication auth) : base(auth) { }

        /// <summary>
        /// https://www.strava.com/api/v3/athletes/:id/routes?access_token=8ce2ec89dc2ef8e48326f7c4ca7323cb38a93b62
        /// </summary>
        /// <returns>All the routes of the currently authenticated athlete.</returns>
        public async Task<List<Route>> GetRoutes()
        {
            return null;
        }

        /// <summary>
        /// Get the route with the specified id. Private routes can not be received by other athletes than the owner.
        /// </summary>
        /// <param name="routeId">The Strava route id.</param>
        /// <returns>The Strava route with the specified id.</returns>
        public async Task<Route> GetRoute(long routeId)
        {
            return null;
        }
    }
}
