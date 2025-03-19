using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Domain.Entities
{
    public sealed class Image : AbstractEntity
    {
        public byte[] File { get; private set; }
        public bool Main { get; private set; }
        public Guid ProductId { get; private set; }
        public Product Product { get; private set; }

        public Image(byte[] file, bool main, Guid productId)
        {
            Validate(file, productId);
            File = file;
            Main = main;
            ProductId = productId;
        }

        private void Validate(byte[] file, Guid productId)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException(ImageErrorMessage.InvalidFile, nameof(file));
            }

            if (productId == Guid.Empty)
            {
                throw new ArgumentException(ImageErrorMessage.InvalidProductId, nameof(productId));
            }
        }
    }
}
