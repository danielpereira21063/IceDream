public static class ProductErrorMessage
{
    public const string ProductIdRequiredForUpdate = "Product ID is required for updates.";
    public const string InvalidName = "Name must be more than 3 characters and not empty.";
    public const string InvalidDescription = "Description must be more than 3 characters and not empty.";
    public const string InvalidPrice = "Price must be greater than zero.";
    public const string InvalidCategoryId = "CategoryId cannot be empty.";
    public const string InvalidImageId = "ImageId cannot be empty.";
}