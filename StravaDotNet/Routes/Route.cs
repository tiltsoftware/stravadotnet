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

using Newtonsoft.Json;
using Strava.Activities;
using Strava.Athletes;

namespace Strava.Routes
{
    public class Route
    {
        [JsonProperty("athlete")]
        public Athlete Athlete { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("elevation_gain")]
        public double Elevation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("map")]
        public Map Map { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("@private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        [JsonProperty("starred")]
        public bool IsStarred { get; set; }

        [JsonProperty("sub_type")]
        public int SubType { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }
}
