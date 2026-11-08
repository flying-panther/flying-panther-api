using System;

namespace Flying.Panther.Domain.Catalog;

public class Rating
{
    public int Id { get; set; }
    public int Stars { get; set; }
    public string UserName { get; set; }
    public string Review { get; set; }

    public Rating(int stars, string userName, string review)
    {
        if (stars < 1 || stars > 5)
        {
            throw new ArgumentException("Stars must be between 1 and 5.", nameof(stars));
        }

        if (string.IsNullOrEmpty(userName))
        {
            throw new ArgumentNullException(nameof(userName));
        }

        Stars = stars;
        UserName = userName;
        Review = review;
    }
}