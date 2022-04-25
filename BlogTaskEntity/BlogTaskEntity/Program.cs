using BlogTaskEntity.Services;
using System;

namespace BlogTaskEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            do
            {
                PostService postService = new PostService();

                Console.WriteLine("1. Post elave et");
                Console.WriteLine("2. Postu edit et");
                Console.WriteLine("3. Id ile postu qaytar");
                Console.WriteLine("4. Butun postlari qaytar");
                Console.WriteLine("5. Id ile postu sil");

                int choose = int.Parse(Console.ReadLine());

                switch(choose){
                    case 1:
                        Console.WriteLine("Title ve content daxil edin:");
                        string title = Console.ReadLine();
                        string content = Console.ReadLine();
                        postService.AddPost(title, content);
                        break;
                    case 2:
                        Console.WriteLine("Id ve title daxil edin:");
                        int id = int.Parse(Console.ReadLine());
                        string title2 = Console.ReadLine();
                        postService.EditPostTitle(id, title2);
                        break;
                    case 3:
                        Console.WriteLine("Id daxil edin:");
                        int id2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(postService.GetPostById(id2).Title);
                        break;
                    case 4:
                        foreach (var item in postService.GetAllPosts())
                        {
                            Console.WriteLine(item.Id + " " + item.Title + " " + item.Content);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Id daxil edin:");
                        int id3 = int.Parse(Console.ReadLine());
                        postService.DeletePost(id3);
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            } while (check);
        }
    }
}
