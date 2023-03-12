﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Records
    {
        public void TopRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = (from productReviews in listproductReviews
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
    }
}
