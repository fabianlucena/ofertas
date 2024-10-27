﻿using RFService.EntitiesLib;
using RFService.IRepo;
using RFService.RepoLib;

namespace RFService.ServicesLib
{
    public abstract class ServiceTimestampsIdUuidEnabledNameTitleTranslatable<Repo, Entity>(Repo repo) : ServiceTimestampsIdUuidEnabledNameTitle<Repo, Entity>(repo)
        where Repo : IRepo<Entity>
        where Entity : EntityTimestampsIdUuidEnabledNameTitleTranslatable
    {
        public override async Task<Entity> ValidateForCreationAsync(Entity data)
        {
            data = await base.ValidateForCreationAsync(data);

            if (data.IsTranslatable == null)
            {
                data.IsTranslatable = true;
            };

            return data;
        }

        public override GetOptions SanitizeForAutoGet(GetOptions options)
        {
            if (options.Filters.TryGetValue("IsTranslatable", out object? value))
            {
                if (value == null)
                {
                    options = new GetOptions(options);
                    options.Filters.Remove("IsTranslatable");
                }
            }

            return base.SanitizeForAutoGet(options);
        }
    }
}
