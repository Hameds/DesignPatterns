using System;
namespace DesignPatterns.Creational.Singleton
{
    //This implementation works but it's not Thread-safe. for more information take a look at this http://www.dotnettips.info/post/1897
    public class President
    {
        static President _instance;

        //It's a private constructor
        President()
        {
        }

        public static President Instance
        {
            get { return _instance ?? (_instance = new President()); }
        }
    }
}
