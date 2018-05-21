
namespace DesignPatterns.Creational.Builder
{
    class WebSite
    {
        private string _title;
        private bool _haveNews;
        private bool _haveImageGallery;
        private bool _haveBlog;

        public WebSite(WebSiteBuilder builder)
        {
            _title = builder.Title;
            _haveNews = builder.HaveNews;
            _haveImageGallery = builder.HaveImageGallery;
            _haveBlog = builder.HaveBlog;
        }

        public string GetSiteDescription()
        {
            return $"The website title is «{_title}» which {(_haveBlog?"have":"haven't")} blog, {(_haveNews ? "have" : "haven't")} news & {(_haveImageGallery ? "have" : "haven't")} image gallery";
        }
    }
}
