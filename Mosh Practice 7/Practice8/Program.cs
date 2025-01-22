using Practice8;

internal class Program
{
    public static void Main(string[] args)
    {
        var post = new Post();
        post.Like();
        post.Like();
        post.Like();
        post.Like();
        post.Like();

        Console.WriteLine(post.LikeCount);

        post.DisLike();




        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();
        post.DisLike();

        Console.WriteLine(post.LikeCount);

    }
}