// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNet.FeatureModel;
using Microsoft.Framework.Configuration;

namespace Microsoft.AspNet.Hosting.Server
{
    public interface IServerFactory
    {
        IServerInformation Initialize(IConfiguration configuration);
        IDisposable Start(IServerInformation serverInformation, Func<IFeatureCollection, Task> application);
    }
}