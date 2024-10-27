﻿using RFService.Exceptions;
using RFService.EntitiesLib;
using RFService.IRepo;
using RFService.RepoLib;

namespace RFService.ServicesLib
{
    public abstract class ServiceTimestampsId<Repo, Entity>(Repo repo) : ServiceTimestamps<Repo, Entity>(repo)
        where Repo : IRepo<Entity>
        where Entity : EntityTimestampsId
    {
        public override async Task<Entity> ValidateForCreationAsync(Entity data)
        {
            data = await base.ValidateForCreationAsync(data);

            if (data.Id != 0)
            {
                throw new ForbidenIdForCreationException();
            }

            return data;
        }

        public override GetOptions SanitizeForAutoGet(GetOptions options)
        {
            if (options.Filters.TryGetValue("Id", out object? value))
            {
                options = new GetOptions(options);
                if (value != null
                    && (Int64)value > 0
                )
                {
                    options.Filters = new Dictionary<string, object?> { { "Id", value } };
                    return options;
                }
                else {
                    options.Filters.Remove("Id");
                }
            }

            return base.SanitizeForAutoGet(options);
        }
    }
}