namespace ECommerceSearchFunction
{
    public class SearchService
    {
        public static Product LinearSearch(Product[] products, string productName)
        {
            foreach (Product product in products)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }

            return null;
        }

        public static Product BinarySearch(Product[] products, string productName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = string.Compare(products[mid].ProductName, productName);

                if (result == 0)
                    return products[mid];

                if (result < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}