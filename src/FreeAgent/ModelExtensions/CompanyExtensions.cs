﻿using FreeAgent.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeAgent
{
    public static class CompanyExtensions
    {
        public static async Task<Company> GetCompanyAsync(this FreeAgentClient client)
        {
            var result = await client.Execute(c => c.CompanyDetails(client.Configuration.CurrentHeader));
            return result.Company;
        }

        public static async Task<List<TaxTimeline>> GetTaxTimelinesAsync(this FreeAgentClient client)
        {
            var result = await client.Execute(c => c.TaxTimelines(client.Configuration.CurrentHeader));
            return result.TimelineItems;
        }
    }
}