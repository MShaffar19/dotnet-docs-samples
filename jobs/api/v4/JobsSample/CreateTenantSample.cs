﻿// Copyright 2020 Google Inc.
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

using System;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Talent.V4Beta1;

namespace GoogleCloudSamples
{
    internal class CreateTenantSample
    {
        // [START job_search_create_tenant_beta]
        public static object CreateTenant(string projectId, string externalId)
        {
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            Tenant tenant = new Tenant
            {
                ExternalId = externalId,
            };
            string parent = ProjectName.Format(projectId);
            CreateTenantRequest request = new CreateTenantRequest
            {
                Parent = parent,
                Tenant = tenant
            };
            Tenant response = tenantServiceClient.CreateTenant(request);

            Console.WriteLine($"Created Tenant.");
            Console.WriteLine($"Name: {response.Name}");
            Console.WriteLine($"External ID: {response.ExternalId}");
            return 0;
        }
        // [END job_search_create_tenant_beta]
    }
}
