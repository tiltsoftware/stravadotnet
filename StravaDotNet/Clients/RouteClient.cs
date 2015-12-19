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

using Strava.Api;
using Strava.Athletes;
using Strava.Authentication;
using Strava.Common;
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
        /// Retrieves all the routes of the specified athlete.
        /// </summary>
        /// <returns>All the routes of the athlete with the specified Strava Athlete Id.</returns>
        public async Task<List<Route>> GetRoutes(long athleteId)
        {
            string getUrl = string.Format("{0}?access_token={1}", string.Format(Endpoints.Routes, athleteId), Authentication.AccessToken);
            string json = await Http.WebRequest.SendGetAsync(new System.Uri(getUrl));

            return Unmarshaller<List<Route>>.Unmarshal(json);
        }

        /// <summary>
        /// Retrieves all the routes of the currently authenticated athlete.
        /// </summary>
        /// <returns>All the routes of the currently authenticated athlete.</returns>
        public async Task<List<Route>> GetRoutes()
        {
            AthleteClient athleteClient = new AthleteClient(Authentication);
            Athlete athlete = await athleteClient.GetAthleteAsync();

            return await GetRoutes(athlete.Id);
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
