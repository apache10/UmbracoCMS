using Umbraco.Cms.Web.Common.PublishedModels;

namespace Company.Web.Models
{

    public class NavigationViewModel
    {
        public string HomeUrl { get; set; }
        public string HomeName { get; set; }
        public IEnumerable<Umbraco.Cms.Core.Models.Link> NavigationItems { get; set; }
    }
}