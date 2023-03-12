using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true},
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 3.5, Review = "not Good", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4.8, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 6, Rating = 4.1, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 3.6, Review = "not Good", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 8, Rating = 4.3, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 9, Rating = 3.7, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 4.4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 8, Rating = 4.6, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 9, Rating = 4.7, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 10, Rating = 4.8, Review = "Good", isLike = true }
            };
            foreach (ProductReview Pr in ProductReviewlist)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
            Records r = new Records();
            r.RetriveIdandReviewRecords(ProductReviewlist);
        }
    }
}
