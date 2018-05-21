
namespace DesignPatterns.Creational.Builder
{
    class WebSiteBuilder
    {

        public string Title;
        public bool HaveNews;
        public bool HaveImageGallery;
        public bool HaveBlog;

        public WebSiteBuilder(string title)
        {
            this.Title = title;
        }

        public WebSiteBuilder AddNewsModule()
        {
            this.HaveNews = true;
            return this;
        }

        public WebSiteBuilder AddImageGalleryModule()
        {
            this.HaveImageGallery = true;
            return this;
        }

        public WebSiteBuilder AddBlogModule()
        {
            this.HaveBlog = true;
            return this;
        }

        public WebSite Build()
        {
            return new WebSite(this);
        }
    }
}
