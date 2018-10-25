namespace Sitecore.Support.XA.Feature.SiteMetadata.Repositories.OpenGraphMetadata
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.Data;
  using Sitecore.Data.Items;
  using Sitecore.DependencyInjection;
  using Sitecore.XA.Feature.SiteMetadata;
  using Sitecore.XA.Feature.SiteMetadata.Models;
  using Sitecore.XA.Feature.SiteMetadata.Repositories;
  using Sitecore.XA.Feature.SiteMetadata.Services;
  using System.Collections.Generic;
  using System.Linq;

  public class OpenGraphMetadataRepository : Sitecore.XA.Feature.SiteMetadata.Repositories.OpenGraphMetadata.OpenGraphMetadataRepository
  {
    public OpenGraphMetadataRepository()
    {
      Mapping = new Dictionary<string, ID>
        {
            {
                "og:description",
                Templates._OpenGraphMetadata.Fields.OpenGraphDescription
            },
            {
                "og:type",
                Templates._OpenGraphMetadata.Fields.OpenGraphType
            },
            {
                "og:site_name",
                Templates._OpenGraphMetadata.Fields.OpenGraphSiteName
            },
            {
                "og:admins",
                Templates._OpenGraphMetadata.Fields.OpenGraphAdmins
            },
            {
                "og:image",
                Templates._OpenGraphMetadata.Fields.OpenGraphImageUrl
            }
        };
    }
  }
}