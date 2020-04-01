using System;

namespace homework4
{
    public class PhotoAlbum
    {
        private int NumberOfPages = 16;

        public PhotoAlbum()
        {
                
        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        public void GetNumberOfPages()
        {
            Console.WriteLine($"the number of pages in the album is: {NumberOfPages}");
        }
    }

    public class BigPhotoAlbum
    {
        private int NumberOfPages = 64;
        public BigPhotoAlbum()
        {
            
        }
        public void GetNumberOfPages()
        {
            Console.WriteLine($"the number of pages in the album is: {NumberOfPages}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1

            //Create a class "PhotoAlbum" with a private attribute "numberOfPages".
            //It should also have a public method "GetNumberOfPages",
            //which will return the number of pages.
            //The default constructor will create an album with 16 pages.
            //There will be an additional constructor, with which we can specify the number of pages
            //we want in the album.
            //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
            //In main method create a "PhotoAlbum" instance with its default constructor and one with
            //24 pages.
            //Also create "BigPhotoAlbum" and show the number of pages that the three albums have.

            var PhotoAlbum1 = new PhotoAlbum();
            PhotoAlbum1.GetNumberOfPages();

            var PhotoAlbum2 = new PhotoAlbum(24);
            PhotoAlbum2.GetNumberOfPages();

            var PhotoAlbum3 = new BigPhotoAlbum();
            PhotoAlbum3.GetNumberOfPages();

        }
    }
}
