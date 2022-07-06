﻿// Copyright 2021 Wargaming
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using BuildTimeLogger.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildTimeLogger.Logger
{
    public abstract class IBuildLogger
    {
        /// <summary>
        /// Function for logging a single datapoint
        /// </summary>
        /// <param name="data">A single BuildLogModel to serialize</param>
        /// <returns></returns>
        public abstract Task LogBuildDataAsync(BuildLogModel data);

        /// <summary>
        /// Function for logging multiple datapoints
        /// </summary>
        /// <param name="datas">List of BuildLogModel objects to serialize</param>
        /// <returns></returns>
        public abstract Task LogBuildDataAsync(List<BuildLogModel> datas);

        /// <summary>
        /// Function that can be used to test the connection status
        /// </summary>
        /// <returns></returns>
        public abstract Task CheckConnectionAsync();

    }
}
